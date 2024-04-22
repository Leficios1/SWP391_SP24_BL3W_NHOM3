using SWP391_BL3W.DTO.ModelPaymentOnline;
using SWP391_BL3W.DTO.Request;

namespace SWP391_BL3W.Services.Interface
{
    public interface IPaymentOnlineService
    {

        public Task<string> CallAPIPayByUserId(int userId, int WhoAreYou, int orderId);
        public Task<ResponsePayment> GetInformationPayment(VNPayRequestDTO dto);
    }
}