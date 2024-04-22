using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Request
{
    public class BlogRequestDTO
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        [Url]
        public string ImageUrl {  get; set; } = null!;
        public int UserId { get; set; }
        public int CategoryBlogID { get; set; }
    }
}
