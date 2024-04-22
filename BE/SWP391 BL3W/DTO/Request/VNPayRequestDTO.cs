using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Request
{
    public class VNPayRequestDTO
    {
        public int userId {  get; set; }
        [Url]
        public string urlResponse { get; set; } = null!;
    }
}
