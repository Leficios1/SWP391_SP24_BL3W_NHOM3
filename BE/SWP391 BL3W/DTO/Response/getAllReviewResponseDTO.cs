namespace SWP391_BL3W.DTO.Response
{
    public class getAllReviewResponseDTO
    {
        public List<ReviewresponseDTO> review {  get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
}
