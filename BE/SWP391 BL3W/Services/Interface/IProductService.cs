using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Services.Interface
{
    public interface IProductService
    {
        public Task<StatusResponse<CreateProductDTO>> create(CreateProductDTO dto);
        public Task<StatusResponse<ProductsResponseDTO>> getAll(int? size, int? page);
        public Task<StatusResponse<ProductDetailsResponseDTO>> getProductDetailbyId(int id);
        public Task<StatusResponse<ProductDetailsResponseDTO>> updateProduct(ProductDetailsResponseDTO dto);
        public Task<StatusResponse<ProductsResponseDTO>> search(string? name);
    }
}
