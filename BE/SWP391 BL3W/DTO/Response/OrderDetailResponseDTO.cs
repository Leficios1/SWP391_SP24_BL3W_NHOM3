using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Response
{
    public class OrderDetailResponseDTO
    {
        public ProductResponseDTO product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiredWarranty {  get; set; }
    }
    public class ProductResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Url]
        public string? ImageUrl { get; set; }
    }
}
