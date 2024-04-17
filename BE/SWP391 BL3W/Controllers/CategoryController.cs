using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391_BL3W.Services;
using SWP391_BL3W.Services.Interface;
using System.Drawing;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.getAllCategory();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }

        [HttpGet("get-product-by-category/{id}")]
        public async Task<IActionResult> GetProductsByCategory([FromRoute] int id)
        {
            var response = await _categoryService.searchProductsByCategory(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
    }
}
