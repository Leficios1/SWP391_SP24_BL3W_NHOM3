namespace SWP391_BL3W.DTO.Request
{
    public class CreateBlogDTO
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public int UserId { get; set; }

        public int CategoryBlogID { get; set; }
    }
}
