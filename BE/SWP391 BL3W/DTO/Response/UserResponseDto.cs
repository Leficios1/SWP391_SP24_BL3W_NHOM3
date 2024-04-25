namespace SWP391_BL3W.DTO.Response
{
    public class GetAllUserResponseDTO
    {
        public List<UserResponseDto> Result { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? AvatarUrl { get; set; }
        public string? Gender { get; set; }
        public bool status { get; set; }
        public int RoleId { get; set; }

    }
}
