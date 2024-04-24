using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Services;
using SWP391_BL3W.Services.Interface;
using System.Reflection.Metadata;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getAll(int? size, int? page)
        {
            var response = await _blogService.GetAllBlogsAsync(size, page);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlogById(int id)
        {
            var response = await _blogService.GetBlogByIdAsync(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

        [HttpPost]
        public async Task<ActionResult<BlogsDTO>> CreateBlog(BlogRequestDTO dto)
        {
            var response = await _blogService.CreateBlogAsync(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlogAsync(UpdateBlogDTO dto)
        {
            var response = await _blogService.UpdateBlogAsync(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogAsync(int id)
        {
            var response = await _blogService.DeleteBlogAsync(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

    }
}
