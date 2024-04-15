using System.ComponentModel.DataAnnotations;

namespace SWP391_BL3W.DTO.Request
{
    public class UpdateBlogDTO
    {
        [Required(ErrorMessage = "The blog ID is required.")]
        public int Id { get; set; }

        [StringLength(500, MinimumLength = 2, ErrorMessage = "The title must be between 2 and 500 characters.")]
        public string Title { get; set; }

        [StringLength(1000, MinimumLength = 2, ErrorMessage = "The content must be between 2 and 1000 characters.")]
        public string Content { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Invalid user ID.")]
        public int UserId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Invalid category ID.")]
        public int CategoryId { get; set; }
    }
}
