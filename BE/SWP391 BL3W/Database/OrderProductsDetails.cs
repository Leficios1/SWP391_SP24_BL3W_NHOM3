using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391_BL3W.Database
{
    [Table("OrderProductsDetails")]
    public class OrderProductsDetails
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int OrderDetailsId {  get; set; }
        [Required]
        public int ProductsDetailsId { get; set; }
    }
}
