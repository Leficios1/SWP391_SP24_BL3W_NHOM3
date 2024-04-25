using System.Threading.Tasks;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface IBlogService
    {
        Task<StatusResponse<BlogsDTO>> CreateBlogAsync(BlogRequestDTO dto);
        Task<StatusResponse<bool>> DeleteBlogAsync(int id);
        Task<StatusResponse<BlogsResponseDTO>> GetAllBlogsAsync(int? size, int? page);
        Task<StatusResponse<BlogsResponseDTO>> UpdateBlogAsync(UpdateBlogDTO dto);
        Task<StatusResponse<BlogDetailsResponseDTO>> GetBlogByIdAsync(int id);
        Task<StatusResponse<CategoryBlogResponseDTO>> getNameCategoryBlogById(int id);
        Task<StatusResponse<List<CategoryBlogResponseDTO>>> GetAllCategoriesAsync();
    }
}
