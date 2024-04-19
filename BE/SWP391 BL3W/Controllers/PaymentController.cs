using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("vn-pay/{userId}/{returnUrl}/{orderId}")]
        public async Task<IActionResult> PayWithUserId([FromRoute] int userId,[FromRoute] string returnUrl,[FromRoute] int orderId)
        {
            string result = await _vnPayService.CallAPIPayByUserId(userId, returnUrl, orderId);
            return Ok(result);
        }

        [HttpGet("vn-pay/check-payment")]
        public async Task<IActionResult> Check([FromQuery] string url, [FromQuery] int userId)
        {
            var result = await _vnPayService.GetInformationPayment(userId, url);
            return Ok(result);
        }
    }

}