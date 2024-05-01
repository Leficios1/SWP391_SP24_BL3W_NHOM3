using SWP391_BL3W.DTO.Response;
using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Request
{
    public class UpdateProductsDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Url]
        public string? ImageUrl { get; set; }
        public int? quantity { get; set; }
        public decimal? price { get; set; }
        public int WarrantyPeriod { get; set; }
        public List<ProductsDetailDTO> Details { get; set; }
        public List<ImageDTOs> ImageDTOs { get; set; }

    }
}
