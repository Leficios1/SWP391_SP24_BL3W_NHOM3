using System.Threading.Tasks;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface IBlogService
    {
        Task<StatusResponse<BlogsDTO>> CreateBlogAsync(BlogsDTO dto);
        Task<StatusResponse<BlogsDTO>> DeleteBlogAsync(int id);
        Task<StatusResponse<BlogsResponseDTO>> GetAllBlogsAsync();
        Task<StatusResponse<BlogsResponseDTO>> UpdateBlogAsync(int id, UpdateBlogDTO dto);
        Task<StatusResponse<BlogDetailsResponseDTO>> GetBlogByIdAsync(int id);
    }
}
