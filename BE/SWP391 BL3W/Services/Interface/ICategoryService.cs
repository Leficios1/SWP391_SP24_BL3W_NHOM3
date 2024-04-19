using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface ICategoryService
    {
        public Task<StatusResponse<List<Category>>> getAllCategory();
        public Task<StatusResponse<List<ProductDTO>>> searchProductsByCategory(int category);
    }
}
