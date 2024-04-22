namespace SWP391_BL3W.DTO.Response
{
    public class ReviewresponseDTO
    {
        public int Id {  get; set; }
        public string NameUser { get; set; } = null!;
        public int ProductId { get; set; }
        public string Comment { get; set; } = null!;
        public int Rating { get; set; }
    }
}
