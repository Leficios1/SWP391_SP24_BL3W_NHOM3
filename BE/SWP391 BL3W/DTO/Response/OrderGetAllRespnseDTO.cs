namespace SWP391_BL3W.DTO.Response
{
    public class OrderGetAllRespnseDTO
    {
            public List<OrderDTO> Orders { get; set; }
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
            public int PageSize { get; set; }
            public int TotalItems { get; set; }
    }

    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int status { get; set; }
        public string? statusMessage { get; set; }
        public string PaymentName { get; set; }
        public string? NameCustomer { get; set; }
        public string? AddressCustomer { get; set; }
        public string? PhoneCustomer { get; set; }

    }
}
