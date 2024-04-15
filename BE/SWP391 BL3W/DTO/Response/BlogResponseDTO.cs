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
        /*public int Id { get; set; }
        [Required, MinLength(2), MaxLength(500), DataType(DataType.Text)]
        public string Title { get; set; }
        [Required, MinLength(2), MaxLength(1000), DataType(DataType.Text)]
        public string Content { get; set; }
        [Required, MinLength(2), MaxLength(1000), DataType(DataType.Text), Url]
        public string ImageUrl { get; set; }
        [Range(1, 1000)]
        public int UserId { get; set; }
        [Range(1, 1000)]
        public int CategoryBlogID { get; set; }*/
        public int Id { get; set; }
       
        public string Title { get; set; }
        
        public string Content { get; set; }
       
        public string ImageUrl { get; set; }
        
        public int UserId { get; set; }
       
        public int CategoryBlogID { get; set; }

    }


}