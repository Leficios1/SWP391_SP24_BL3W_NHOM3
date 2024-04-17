
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
                        var order = _mapper.Map<Order>(dto);
                        order.statusMessage = "";
                        order.TotalPrice = dto.OrderDetails.Sum(s => s.Price);
                        await _baseRepository.AddAsync(order);
                        //await _baseRepository.SaveChangesAsync();
                        foreach (var exist in dto.OrderDetails)
                        {
                            var product = await _productsRepository.Get().Where(x => x.Id == exist.ProductId).SingleOrDefaultAsync();
                            if (product.quantity - exist.Quantity < 0)
                            {
                                response.statusCode = HttpStatusCode.BadRequest;
                                response.Errormessge = "Quantity is not enough!";
                                throw new Exception();
                            }
/*                            else
                            {
                                product.quantity = product.quantity - exist.Quantity;
                                var orderdetails = _mapper.Map<OrderDetail>(exist);
                                orderdetails.OrderID = await _baseRepository.Get().OrderByDescending(x => x.OrderId).Select(x => x.OrderId).FirstOrDefaultAsync();
                                await _orderDetailRepository.AddAsync(orderdetails);
                            }*/
                        }

                        await _baseRepository.SaveChangesAsync();
                        response.Errormessge = "Create SuccessFul!";
                        response.statusCode = HttpStatusCode.OK;
                        response.Data = null;
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
    }
}
