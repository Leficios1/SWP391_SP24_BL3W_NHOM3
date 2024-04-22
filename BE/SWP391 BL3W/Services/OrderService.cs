
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;
using System.Xml;

namespace SWP391_BL3W.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Order> _baseRepository;
        private readonly SWPContext _context;
        private readonly IBaseRepository<OrderDetail> _orderDetailRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Product> _productsRepository;
        public OrderService(IMapper mapper, IBaseRepository<Order> baseRepository, SWPContext context, IBaseRepository<OrderDetail> orderDetailRepository
            , IBaseRepository<User> userRepository, IBaseRepository<Product> productsRepositpry)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
            _context = context;
            _orderDetailRepository = orderDetailRepository;
            _userRepository = userRepository;
            _productsRepository = productsRepositpry;
        }

        public async Task<StatusResponse<OrderResponseDTO>> create(OrderResquestDTO dto)
        {
            var response = new StatusResponse<OrderResponseDTO>();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var user = await _userRepository.GetById(dto.UserId);
                    if (user == null)
                    {
                        response.statusCode = HttpStatusCode.NotFound;
                        response.Errormessge = "Not Found User!!!";
                        return response;
                    }
                    else
                    {
                        foreach (var orderDetailDto in dto.OrderDetails)
                        {
                            var product = await _productsRepository.GetById(orderDetailDto.ProductId);
                            if (product == null)
                            {
                                response.statusCode = HttpStatusCode.BadRequest;
                                response.Errormessge = $"Product with ID {orderDetailDto.ProductId} not found!";
                                return response;
                            }
                            orderDetailDto.ExpiredWarranty = DateTime.Now.AddMonths(product.WarrantyPeriod);
                        }
                        var order = _mapper.Map<Order>(dto);
                        //order.statusMessage = "";
                        order.UserId = dto.UserId;
                        decimal totalPrice = 0;
                        foreach (var exist in dto.OrderDetails)
                        {
                            var product = await _productsRepository.GetById(exist.ProductId);
                            if (product == null)
                            {
                                response.statusCode = HttpStatusCode.NotFound;
                                response.Errormessge = $"Product with ID {exist.ProductId} not found!";
                                return response;
                            }
                            totalPrice += product.price * exist.Quantity;
                        }
                        order.TotalPrice = totalPrice;
                        await _baseRepository.AddAsync(order);
                        //await _baseRepository.SaveChangesAsync();
                        foreach (var exist in dto.OrderDetails)
                        {
                            var product = await _productsRepository.Get().Where(x => x.Id == exist.ProductId).SingleOrDefaultAsync();
                            if (product.quantity - exist.Quantity < 0)
                            {
                                response.statusCode = HttpStatusCode.BadRequest;
                                response.Errormessge = "Quantity is not enough!";
                                return response;
                            }
                            else
                            {
                                product.quantity = product.quantity - exist.Quantity;
                                var orderdetails = _mapper.Map<OrderDetail>(exist);
                                orderdetails.OrderID = await _baseRepository.Get().OrderByDescending(x => x.OrderId).Select(x => x.OrderId).FirstOrDefaultAsync();
                                //await _orderDetailRepository.AddAsync(orderdetails);
                            }
                        }
                        await _baseRepository.SaveChangesAsync();
                        var map = _mapper.Map<OrderResponseDTO>(order);
                        map.TotalPrice = totalPrice;
                        response.Errormessge = "Create SuccessFul!";
                        response.statusCode = HttpStatusCode.OK;
                        response.Data = map;
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    response.statusCode = HttpStatusCode.InternalServerError;
                    response.Errormessge = ex.Message;
                    response.Data = null;
                    return response;
                }
            }
            return response;
        }

        public async Task<StatusResponse<OrderGetAllRespnseDTO>> getAllOrderAsync(int? page, int? size)
        {
            var response = new StatusResponse<OrderGetAllRespnseDTO>();
            try
            {
                int pageSize = size ?? 15;
                int pageNumber = page ?? 1;

                List<Order> allOrders = await _context.Orders
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                int totalItems = await _context.Orders.CountAsync();
                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                var orderResponseDTOs = allOrders.Select(order => new OrderDTO
                {
                    Id = order.OrderId,
                    OrderDate = order.OrderDate,
                    TotalPrice = order.TotalPrice,
                    status = order.status,
                    statusMessage = order.statusMessage,
                    PaymentName = order.PaymentName,
                    NameCustomer = order.NameCustomer,
                    AddressCustomer = order.AddressCustomer,
                    PhoneCustomer = order.PhoneCustomer,
                }).ToList();

                var responseDTO = new OrderGetAllRespnseDTO
                {
                    Orders = orderResponseDTOs,
                    TotalPages = totalPages,
                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                    TotalItems = totalItems
                };

                response.Data = responseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Get all orders with pagination successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                response.Data = null;
            }
            return response;
        }

        public async Task<StatusResponse<List<BestSellerReponseDTO>>> getBestSellerProductByCategory()
        {
            var response = new StatusResponse<List<BestSellerReponseDTO>>();
            try
            {
                var startDate = DateTime.Today.AddYears(-1);

                var ordersWithinYear = await _baseRepository.Get()
                    .Include(o => o.OrdersDetail)
                    .ThenInclude(od => od.Product)
                    .Where(o => o.OrderDate >= startDate)
                    .ToListAsync();

                if (ordersWithinYear == null || !ordersWithinYear.Any())
                {
                    response.statusCode = HttpStatusCode.BadRequest;
                    response.Errormessge = "No orders found within the past year.";
                    return response;
                }

                var categoryQuantities = new Dictionary<int, int>();
                foreach (var order in ordersWithinYear)
                {
                    foreach (var orderDetail in order.OrdersDetail)
                    {
                        var categoryId = orderDetail.Product.CategoryID;
                        var quantity = orderDetail.Quantity;
                        if (categoryQuantities.ContainsKey(categoryId))
                        {
                            categoryQuantities[categoryId] += quantity;
                        }
                        else
                        {
                            categoryQuantities[categoryId] = quantity;
                        }
                    }
                }

                var top4Categories = categoryQuantities.OrderByDescending(kv => kv.Value).Take(4);

                var bestSellingCategories = new List<BestSellerReponseDTO>();
                foreach (var kv in top4Categories)
                {
                    var category = await _context.Categories.FindAsync(kv.Key);
                    if (category != null)
                    {
                        bestSellingCategories.Add(new BestSellerReponseDTO
                        {
                            categoryName = category.CategoryName,
                            productBestSeller = kv.Value
                        });
                    }
                }

                response.Data = bestSellingCategories;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Retrieved best-selling categories within the past year successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }


        public async Task<StatusResponse<List<OrderResponseDTO>>> getOrderbyUserId(int userId)
        {
            var response = new StatusResponse<List<OrderResponseDTO>>();
            try
            {
                var orders = await _context.Orders
                    .Where(o => o.UserId == userId)
                    .ToListAsync();

                var orderResponseDTOs = _mapper.Map<List<Order>, List<OrderResponseDTO>>(orders);
                response.Data = orderResponseDTOs;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Get orders by user id successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                response.Data = null;
                return response;
            }
            return response;
        }

        public async Task<StatusResponse<List<OrderDetailResponseDTO>>> getOrderdetailByOrderId(int orderId)
        {
            var response = new StatusResponse<List<OrderDetailResponseDTO>>();
            try
            {
                var orderDetails = await _orderDetailRepository.Get().Where(x => x.OrderID == orderId).ToListAsync();
                if (orderDetails == null || !orderDetails.Any())
                {
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Order details not found for the specified order ID.";
                    return response;
                }

                var orderDetailDTOs = new List<OrderDetailResponseDTO>();
                foreach (var orderDetail in orderDetails)
                {
                    var product = await _productsRepository.GetById(orderDetail.ProductId);
                    if (product != null)
                    {
                        var orderDetailDTO = new OrderDetailResponseDTO
                        {
                            product = new ProductResponseDTO
                            {
                                Id = product.Id,
                                Name = product.Name,
                                ImageUrl = product.ImageUrl,
                            },
                            Quantity = orderDetail.Quantity,
                            Price = orderDetail.Price,
                            ExpiredWarranty = orderDetail.ExpiredWarranty
                        };
                        orderDetailDTOs.Add(orderDetailDTO);
                    }
                }

                response.Data = orderDetailDTOs;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Retrieved order details successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }


        public async Task<StatusResponse<DashBoardOrderResponeDTO>> getTotalPriceByOrderDate(DateTime orderDate, int type)
        {
            var response = new StatusResponse<DashBoardOrderResponeDTO>();
            try
            {
                int totalOrder = 0;
                decimal totalPrice = 0;

                switch (type)
                {
                    case 1:
                        totalOrder = await _context.Orders
                            .Where(o => o.OrderDate.Date == orderDate.Date)
                            .CountAsync();
                        totalPrice = await _context.Orders
                            .Where(o => o.OrderDate.Date == orderDate.Date)
                            .SumAsync(o => o.TotalPrice);
                        break;
                    case 2:
                        DateTime weekStartDate = orderDate.Date.AddDays(-7);
                        totalOrder = await _context.Orders
                            .Where(o => o.OrderDate.Date >= weekStartDate && o.OrderDate.Date <= orderDate.Date)
                            .CountAsync();
                        totalPrice = await _context.Orders
                            .Where(o => o.OrderDate.Date >= weekStartDate && o.OrderDate.Date <= orderDate.Date)
                            .SumAsync(o => o.TotalPrice);
                        break;
                    case 3: 
                        DateTime monthStartDate = new DateTime(orderDate.Year, orderDate.Month, 1);
                        DateTime monthEndDate = monthStartDate.AddMonths(1).AddDays(-1);
                        totalOrder = await _context.Orders
                            .Where(o => o.OrderDate.Date >= monthStartDate && o.OrderDate.Date <= monthEndDate)
                            .CountAsync();
                        totalPrice = await _context.Orders
                            .Where(o => o.OrderDate.Date >= monthStartDate && o.OrderDate.Date <= monthEndDate)
                            .SumAsync(o => o.TotalPrice);
                        break;
                    default:
                        response.statusCode = HttpStatusCode.BadRequest;
                        response.Errormessge = "Invalid type. Type must be 1 (daily), 2 (weekly), or 3 (monthly).";
                        return response;
                }

                var dashboardDTO = new DashBoardOrderResponeDTO
                {
                    TotalOrder = totalOrder,
                    Totalprice = totalPrice
                };

                response.Data = dashboardDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Get total order and total price by order date successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }


        public async Task<StatusResponse<bool>> updateOrderAsync(int orderId, int status)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var existOrder = await _baseRepository.GetById(orderId);
                if (existOrder == null)
                {
                    response.Data = false;
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Not Found Order";
                    return response;
                }
                existOrder.status = status;
                _baseRepository.Update(existOrder);
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";

            }catch(Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                response.Data = false;
            }
            return response;
        }
    }
}
