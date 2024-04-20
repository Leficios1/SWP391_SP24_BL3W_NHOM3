using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services;
using SWP391_BL3W.Services.Interface;
using System.Drawing;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly SWPContext _context;

        public OrderController(IOrderService orderService, SWPContext context)
        {
            _orderService = orderService;
            _context = context;
        }

        [Authorize(Roles = "1 , 3")]
        [HttpGet("getAll")]
        public async Task<IActionResult> getAll (int? page, int? size)
        {
            var response = await _orderService.getAllOrderAsync(size, page);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }

        [Authorize]
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> getOrderById([FromRoute] int id)
        {
            var response = await _orderService.getOrderbyUserId(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }

        [Authorize(Roles = "1")]
        [HttpGet("Totalprice")]
        public async Task<IActionResult> totalPriceByOderDate(DateTime ordertime, int type)
        {
            var response = await _orderService.getTotalPriceByOrderDate(ordertime, type);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [Authorize(Roles = "1")]
        [HttpGet("bestsellerbycategy")]
        public async Task<IActionResult> getBestSellerByCategory()
        {
            var response = await _orderService.getBestSellerProductByCategory();
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [Authorize(Roles = "1")]
        [HttpGet("getorderdetailsbyorderid/{id}")]
        public async Task<IActionResult> getOrderDetailsByOrderId([FromRoute]int id)
        {
            var response = await _orderService.getOrderdetailByOrderId(id);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [Authorize]
        [HttpPost("create")]
        public async Task<IActionResult> create(OrderResquestDTO dto)
        {
            var response = await _orderService.create(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }

        [Authorize(Roles = "1 , 3")]
        [HttpPut("updateStatus/{id}/{status}")]
        public async Task<IActionResult> updateStatusOrder([FromRoute] int id,[FromRoute] int status)
        {
            var response = await _orderService.updateOrderAsync(id, status);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
    }
}
