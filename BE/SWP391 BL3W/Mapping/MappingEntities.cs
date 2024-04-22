using AutoMapper;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;

namespace SWP391_BL3W.Mapping
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<CreateUserDTO, User>().ReverseMap();
            CreateMap<UserResponseDto, User>().ReverseMap();

            CreateMap<CreateProductDTO, Product>()
            .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.CategoryID))
            .ForMember(dest => dest.Category, opt => opt.Ignore())
            .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details));
            CreateMap<ProductDetailDTO, ProductsDetail>();

            CreateMap<UpdateProductsDTO,Product>().ReverseMap();
            CreateMap<ProductDTO, Product>().ReverseMap();

            CreateMap<OrderResquestDTO, Order>().ForMember(dest => dest.OrdersDetail, opt => opt.MapFrom(x => x.OrderDetails)).ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();
            CreateMap<BlogsDTO, Blog>().ReverseMap();
            CreateMap<BlogsResponseDTO, Blog>().ReverseMap();
            CreateMap<UpdateBlogDTO, BlogDetailsResponseDTO>().ReverseMap();
            CreateMap<IEnumerable<BlogsDTO>, IEnumerable<BlogsResponseDTO>>();
            CreateMap<OrderResponseDTO, Order>().ReverseMap();
            CreateMap<CartRequestDTO, Cart>().ReverseMap();
            CreateMap<CartResponseDTO, Cart>().ReverseMap();
            CreateMap<CartResponsev2DTO, Cart>().ReverseMap();
            CreateMap<ProductCartDTO, Product>().ReverseMap();
            CreateMap<Product, ProductsResponseDTO>().ReverseMap();
            CreateMap<OrderResquestDTO, OrderResponseDTO>().ReverseMap();
            CreateMap<OrderResponseDTO, Order>().ReverseMap();
            CreateMap<ReviewUserRequestDTO, Review>().ReverseMap();
            CreateMap<ReviewUserResponseDTO, Review>().ReverseMap();

        }
    }
}
