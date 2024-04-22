namespace SWP391_BL3W.DTO.Request
{
    public class ReviewUserRequestDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; } = null!;
        public int Rating { get; set; }
    }
}
