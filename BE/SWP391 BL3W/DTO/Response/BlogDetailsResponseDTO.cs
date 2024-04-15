namespace SWP391_BL3W.DTO.Response
{
    
    

        public class BlogDetailsResponseDTO
        {
            public BlogsDTO Blog { get; set; }
            public CategoryBlogDTO Category { get; set; }
            public UserDTO User { get; set; }

        }
    

        public class CategoryBlogDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class UserDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string? phone { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string? AvatarUrl { get; set; }
            public string? Gender { get; set; }
            public bool status { get; set; }
        }
    }
