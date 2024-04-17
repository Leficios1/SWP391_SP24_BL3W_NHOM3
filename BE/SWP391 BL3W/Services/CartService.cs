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
    public class CartService : ICartService
    {
        private readonly IBaseRepository<Cart> _cartRepo;
        private readonly IBaseRepository<User> _userRepo;
        private readonly IBaseRepository<Order> _orderRepo;
        private readonly IBaseRepository<OrderDetail> _orderDetailsRepo;
        private readonly IBaseRepository<Product> _productsRepo;
        public CartService(IBaseRepository<Cart> cartRepo, IBaseRepository<User> userRepo,
            IBaseRepository<Order> orderRepo, IBaseRepository<OrderDetail> orderDetailsRepo, IBaseRepository<Product> productsRepo)
        {
            _cartRepo = cartRepo;
            _userRepo = userRepo;
            _orderRepo = orderRepo;
            _orderDetailsRepo = orderDetailsRepo;
            _productsRepo = productsRepo;
        }
        public async Task<StatusResponse<bool>> AddProductToCartByUserId(CartRequestDTO dto)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var cart = await _cartRepo.Get().Where(x => x.UserId == dto.UserId && x.ProductId == dto.ProductId).FirstOrDefaultAsync();
                if (cart == null)
                {
                    if (!(await CheckQuantity(1, dto.ProductId))) throw new Exception("Quanity is not enough to add to cart.");
                    await _cartRepo.AddAsync(new Cart()
                    {
                        ProductId = dto.ProductId,
                        Quantity = dto.Quantity,
                        UserId = dto.UserId
                    });
                }
                else
                {
                    if (!(await CheckQuantity(cart.Quantity + 1, dto.ProductId))) throw new Exception("Quanity is not enough to add to cart.");
                    cart.Quantity += dto.Quantity;
                    _cartRepo.Update(cart);
                }
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                await _cartRepo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.BadRequest;
                response.Errormessge = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<bool>> CompletedPaymentCartToOrder(int userId, PaymentDTO paymentDTO)
        {
            var response = new StatusResponse<bool>();
            var carts = await _cartRepo.Get().Include(x => x.Product).Where(x => x.UserId == userId).ToListAsync();
            var orderDetails = carts.Select(x => new OrderDetail()
            {
                ExpiredWarranty = DateTime.Now.AddDays(x.Product.WarrantyPeriod),
                Price = x.Product.price,
                Quantity = x.Quantity,
                ProductId = x.ProductId

            }).ToList();

            var totalPrice = orderDetails.Sum(x => x.Price * x.Quantity);

            var order = new Order()
            {
                TotalPrice = totalPrice,
                OrderDate = DateTime.UtcNow,
                UserId = userId,
                PaymentName = paymentDTO.PaymentName,
                AddressCustomer = paymentDTO.AddressCustomer,
                NameCustomer = paymentDTO.NameCustomer,
                OrderId = 0,
                status = 0,
                PhoneCustomer = paymentDTO.PhoneCustomer,
                statusMessage = "Not Paying",

            };
            await _orderRepo.AddAsync(order);
            await _orderRepo.SaveChangesAsync();

            var newOrder = await _orderRepo.Get().OrderBy(x => x.OrderId).LastOrDefaultAsync();
            if (newOrder == null) throw new Exception("Can not generate the order");
            foreach (var item in orderDetails)
            {
                item.OrderID = newOrder.OrderId;

            }

            await _orderDetailsRepo.AddRangeAsync(orderDetails);
            _cartRepo.Delete(carts.ToArray());
            response.Data = true;
            response.statusCode = HttpStatusCode.OK;
            response.Errormessge = "Successful";
            await _cartRepo.SaveChangesAsync();

            return response;
        }
        public async Task<StatusResponse<bool>> DeleteAllProductsInCartByUserId(int userId)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var carts = await _cartRepo.Get().Where(x => x.UserId == userId).ToArrayAsync();
                _cartRepo.Delete(carts);
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                await _cartRepo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge += ex.ToString();
            }
            return response;
        }

        public async Task<StatusResponse<bool>> DeleteProductIdInCartByUserId(int userId, int productId)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var carts = await _cartRepo.Get().Where(x => x.UserId == userId && productId == x.ProductId).ToArrayAsync();
                _cartRepo.Delete(carts);
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                await _cartRepo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge += ex.ToString();
            }
            return response;
        }

        public async Task<StatusResponse<CartDTO[]>> GetCartsByUserId(int userId)
        {
            var response = new StatusResponse<CartDTO[]>();
            var returnedCarts = await _cartRepo.Get().Include(x => x.Product).Where(x => x.UserId == userId).Select(x => new CartDTO()
            {
                ProductId = x.Product.Id,
                ImageUrl = x.Product.ImageUrl,
                Price = x.Product.price,
                ProductName = x.Product.Name,
                Quantity = x.Quantity
            }).ToArrayAsync();
            if(returnedCarts.Length == null)
            {
                response.Data = null;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Cart null";
            }
            response.Data = returnedCarts;
            response.statusCode = HttpStatusCode.OK;
            response.Errormessge = "Successful";
            return response;
        }

        public async Task<StatusResponse<bool>> UpdateQuantityByProductIdAndUserId(int userId, int productId, int quantity)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var cart = await _cartRepo.Get().Where(x => x.UserId == userId && x.ProductId == productId).FirstOrDefaultAsync();
                if (cart == null) throw new Exception("The product is not exist in the cart of user that has id: " + userId);
                if (!(await CheckQuantity(quantity, productId))) throw new Exception("Quanity is not enough to update.");
                cart.Quantity = quantity;
                _cartRepo.Update(cart);
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                await _cartRepo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge += ex.ToString();
            }
            return response;
        }

        private async Task<bool> CheckQuantity(int quantity, int productId)
        {
            var product = await _productsRepo.Get().FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null) throw new Exception("There is no product that has id: " + productId);
            return product.quantity >= quantity;
        }
    }
}