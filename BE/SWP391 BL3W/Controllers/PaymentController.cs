using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services.Interface;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IPaymentOnlineService _vnPayService;
        public PaymentController(IPaymentOnlineService vnPayService)
        {
            _vnPayService = vnPayService;
        }
        [Authorize]
        [HttpGet("vn-pay/{userId}/{orderId}/{WhoAreYou}")]
        public async Task<IActionResult> PayWithUserId([FromRoute] int userId,[FromRoute] int WhoAreYou, [FromRoute] int orderId)
        {
            var result = await _vnPayService.CallAPIPayByUserId(userId, WhoAreYou, orderId);
            return Ok(result);
        }

        [Authorize]
        [HttpPost("vn-pay/check-payment")]
        public async Task<IActionResult> Check(VNPayRequestDTO dto)
        {
            var result = await _vnPayService.GetInformationPayment(dto);
            return Ok(result);
        }
    }

}