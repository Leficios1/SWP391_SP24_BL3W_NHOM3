using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Response
{
    public class CartResponsev2DTO
    {
        public int Id {  get; set; }
        public ProductCartDTO Product { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }

    public class ProductCartDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Url]
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

    }
}
