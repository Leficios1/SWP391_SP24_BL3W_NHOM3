using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface IReviewService
    {
        public Task<StatusResponse<getAllReviewResponseDTO>> GetAll(int? size, int? page);
        public Task<StatusResponse<ReviewUserResponseDTO>> create(ReviewUserRequestDTO dto);
        public Task<StatusResponse<List<ReviewUserResponseDTO>>> getReviewByProductId(int productId);
        public Task<StatusResponse<bool>> deleted(int id);
    }
}
