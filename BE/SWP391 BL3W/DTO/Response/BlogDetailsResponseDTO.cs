namespace SWP391_BL3W.DTO.Response
{
    
    

        public class BlogDetailsResponseDTO
        {
            public BlogsDTO Blog { get; set; }
            public CategoryBlogDTO Category { get; set; }
            public int UserId { get; set; }

        }

        public class CategoryBlogDTO
        {
            public int Id { get; set; }
        public string Name { get; set; } = null!;
        }
    }
