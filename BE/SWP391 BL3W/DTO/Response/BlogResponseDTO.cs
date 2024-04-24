using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Response
{

    public class BlogsResponseDTO
    {
        public List<BlogsDTO> Blogs { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
    public class BlogsDTO
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int UserId { get; set; }

        public int CategoryBlogID { get; set; }

    }


}