using AutoMapper;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;

namespace SWP391_BL3W.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IBaseRepository<Review> _reviewRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ReviewService(IBaseRepository<Review> reviewRepository, IBaseRepository<User> userRepository, IBaseRepository<Product> productRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<StatusResponse<ReviewUserResponseDTO>> create(ReviewUserRequestDTO dto)
        {
            var response = new StatusResponse<ReviewUserResponseDTO>();
            try
            {
                var user = await _userRepository.GetById(dto.UserId);
                if (user == null)
                {
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Not Found User!!!";
                    return response;
                }
                var product = await _productRepository.GetById(dto.ProductId);
                if(product == null)
                {
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Not Found Product!!!";
                    return response;
                }
                var mapper = _mapper.Map<Review>(dto);
                await _reviewRepository.AddAsync(mapper);
                await _reviewRepository.SaveChangesAsync();
                var result = _mapper.Map<ReviewUserResponseDTO>(mapper);
                result.NameUser = user.Name;
                response.Data = result;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful!";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }
    }
}
