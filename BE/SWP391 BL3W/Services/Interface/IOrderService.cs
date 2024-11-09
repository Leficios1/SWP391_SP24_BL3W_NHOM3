using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface IOrderService
    {
        Task<StatusResponse<OrderResponseDTO>> create(OrderResquestDTO dto);
        Task<StatusResponse<List<OrderResponseDTO>>> getOrderbyUserId(int userId, int? status);
        Task<StatusResponse<List<OrderDetailResponseDTO>>> getOrderdetailByOrderId(int orderId);
        Task<StatusResponse<OrderGetAllRespnseDTO>> getAllOrderAsync(int? page, int? size);
        Task<StatusResponse<bool>> updateOrderAsync(int orderId, int status);
        Task<StatusResponse<DashBoardOrderResponeDTO>> getTotalPriceByOrderDate(DateTime? oderdate, int type);
        Task<StatusResponse<List<BestSellerReponseDTO>>> getBestSellerProductByCategory();
        Task<StatusResponse<List<LMFE>>> GetFiveWeekRevenue();
    }
}
