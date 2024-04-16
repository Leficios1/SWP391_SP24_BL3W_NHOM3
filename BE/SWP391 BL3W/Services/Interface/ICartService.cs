using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface ICartService
    {
        public Task<StatusResponse<List<CartResponseDTO>>> getCartbyUserId (int userId);
        public Task<StatusResponse<CartResponseDTO>> createCart (CartRequestDTO dto);
        public Task<StatusResponse<CartResponseDTO>> updateCart (CartUpdateDTO dto);
        public Task<StatusResponse<bool>> deleteCart (int id);
    }
}
