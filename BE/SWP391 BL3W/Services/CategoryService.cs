using AutoMapper;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;

namespace SWP391_BL3W.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<Category> category, IMapper mapper)
        {
            _categoryRepository = category;
            _mapper = mapper;
        }


        public Task<List<StatusResponse<Category>>> getAllCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<List<StatusResponse<ProductsResponseDTO>>> searchProductsByCategory(string category)
        {
            /*            var respnose = new List<StatusResponse<ProductsResponseDTO>>();
                        try
                        {
                            var existingProducts = await _categoryRepository.Get().Where()
                        }*/
            throw new NotImplementedException();

        }
    }
}
