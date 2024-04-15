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

        public BlogController(BlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }


        // GET: api/Blog
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlog()
        {
            var blogs = await _blogService.GetAllBlogsAsync();
            var blogResponseDTOs = _mapper.Map<IEnumerable<BlogsResponseDTO>>(blogs);
            return Ok(blogResponseDTOs);
        }

        // GET: api/Blog/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlogPost(int id)
        {
            var blogPost = await _blogService.GetBlogByIdAsync(id);

            if (blogPost == null)
            {
                return NotFound();
            }

            var blogResponseDTO = _mapper.Map<BlogsResponseDTO>(blogPost);
            return Ok(blogResponseDTO);
        }

        // POST: api/Blog
        [HttpPost]
        public async Task<ActionResult<BlogsResponseDTO>> CreateBlog(BlogsDTO blogsRequestDTO)
        {
            var blog = _mapper.Map<Blog>(blogsRequestDTO);
            await _blogService.CreateBlogAsync(blogsRequestDTO);
            var blogResponseDTO = _mapper.Map<BlogsResponseDTO>(blog);
            return CreatedAtAction(nameof(GetBlog), new { id = blogsRequestDTO.Id }, blogResponseDTO);
        }

        // PUT: api/Blog/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlogAsync(int id, UpdateBlogDTO dto)
        {
            var existingBlog = await _blogService.GetBlogByIdAsync(id);
            if (existingBlog == null)
            {
                return NotFound();
            }

            _mapper.Map(dto, existingBlog);
            await _blogService.UpdateBlogAsync(id, dto);

            return NoContent();
        }

        // DELETE: api/Blog/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogAsync(int id)
        {
            var existingBlog = await _blogService.GetBlogByIdAsync(id);
            if (existingBlog == null)
            {
                return NotFound();
            }

            await _blogService.DeleteBlogAsync(id);

            return NoContent();
        }

    }
}
