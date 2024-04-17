using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services;
using SWP391_BL3W.Services.Interface;
using System.Drawing;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartServie;

        public CartController(ICartService cartServie)
        {
            _cartServie = cartServie;
        }

        [HttpGet("getCartByUserId/{id}")]
        public async Task<IActionResult> getCartByUserId([FromRoute] int id)
        {
            var response = await _cartServie.getCartbyUserId(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }

        [HttpPost("create")]
        public async Task<IActionResult> create(CartRequestDTO dto)
        {
            var response = await _cartServie.createCart(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
    }
}
