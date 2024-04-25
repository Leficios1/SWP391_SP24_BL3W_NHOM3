using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface ICategoryService
    {
        public Task<StatusResponse<List<Category>>> getAllCategory();
        public Task<StatusResponse<ProductsResponseDTO>> SearchProductsByCategory(int? size, int? page, int categoryId);
        public Task<StatusResponse<Category>> getCategoryNameByCategoryId(int categoryId);
    }
}
