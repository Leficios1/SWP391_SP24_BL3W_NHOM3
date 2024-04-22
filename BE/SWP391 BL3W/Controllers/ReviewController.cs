using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services.Interface;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService; 

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getAll(int? size, int? page)
        {
            var response = await _reviewService.GetAll(size, page);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }

        [HttpPost("create")]
        public async Task<IActionResult> create(ReviewUserRequestDTO dto)
        {
            var response = await _reviewService.create(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });

        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> deleted(int id)
        {
            var response = await _reviewService.deleted(id);
            return StatusCode((int)response.statusCode, new {date = response.Data, message = response.Errormessge });
        }
    }
}
