using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface ICategoryService
    {
        public Task<List<StatusResponse<Category>>> getAllCategory();
        public Task<List<StatusResponse<ProductsResponseDTO>>> searchProductsByCategory(string category);
    }
}
