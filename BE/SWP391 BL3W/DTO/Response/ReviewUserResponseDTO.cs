using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Response
{
    public class ReviewUserResponseDTO
    {
        public string NameUser { get; set; } = null!;
        [Url]
        public string ImageUrl { get; set; } = null!;
        public int ProductId { get; set; }
        public string Comment { get; set; } = null!;
        public int Rating { get; set; }
    }
}
