using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;

namespace SWP391_BL3W.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _categoryRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<Category> category, IMapper mapper, IBaseRepository<Product> productRepository)
        {
            _categoryRepository = category;
            _mapper = mapper;
            _productRepository = productRepository;
        }


        public async Task<StatusResponse<List<Category>>> getAllCategory()
        {
            var response = new StatusResponse<List<Category>>();
            try
            {
                var category = await _categoryRepository.Get().ToListAsync();
                response.Data = category;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<List<ProductDTO>>> searchProductsByCategory(int categoryId)
        {
            var response = new StatusResponse<List<ProductDTO>>();
            try
            {
                var existingProducts = await _productRepository.Get().Where(x => x.CategoryID == categoryId).ToListAsync();
                if (existingProducts == null)
                {
                    response.Data = null;
                    response.statusCode = HttpStatusCode.BadRequest;
                    response.Errormessge = $"Products with categoryID {categoryId} doesn't exist!";
                    return response;
                }
                var productDtos = _mapper.Map<List<Product>, List<ProductDTO>>(existingProducts);
                response.Data = productDtos;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Search products by category successfully.";
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }
    }
}
