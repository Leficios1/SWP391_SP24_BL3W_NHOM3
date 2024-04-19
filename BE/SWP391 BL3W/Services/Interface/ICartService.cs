using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface ICartService
    {
        public Task<StatusResponse<bool>> AddProductToCartByUserId(CartRequestDTO dto);
        public Task<StatusResponse<bool>> UpdateQuantityByProductIdAndUserId(int userId, int productId, int quantity);

        public Task<StatusResponse<bool>> CompletedPaymentCartToOrder(int userId, PaymentDTO paymentDTO);

        public Task<StatusResponse<bool>> DeleteAllProductsInCartByUserId(int userId);
        public Task<StatusResponse<bool>> DeleteProductIdInCartByUserId(int userId, int productId);
        public Task<StatusResponse<CartDTO[]>> GetCartsByUserId(int userId);
    }
}