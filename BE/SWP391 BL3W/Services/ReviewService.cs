using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;
using System.Text.RegularExpressions;

namespace SWP391_BL3W.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IBaseRepository<Review> _reviewRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly SWPContext _context;
        private readonly IMapper _mapper;

        public ReviewService(IBaseRepository<Review> reviewRepository, IBaseRepository<User> userRepository,
            IBaseRepository<Product> productRepository, IMapper mapper, SWPContext context)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
            _mapper = mapper;
            _context = context;
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
                if (product == null)
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

        public async Task<StatusResponse<bool>> deleted(int id)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var review = await _reviewRepository.GetById(id);
                if (review == null)
                {
                    response.Data = false;
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Review not exits!";
                    return response;
                }
                _reviewRepository.Delete(review);
                await _reviewRepository.SaveChangesAsync();
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Delete Successful!";
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                return response;
            }
        }

        public async Task<StatusResponse<getAllReviewResponseDTO>> GetAll(int? size, int? page)
        {
            var response = new StatusResponse<getAllReviewResponseDTO>();
            try
            {
                int pageSize = size ?? 15;
                int pageNumber = page ?? 1;
                List<Review> allReivews = await _context.Reviews
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize).ToListAsync();

                int totalItems = await _context.Reviews.CountAsync();
                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                var reviewResponse = new List<ReviewresponseDTO>();
                foreach (var review in allReivews)
                {
                    var userName = await _userRepository.GetById(review.UserId);
                    var reviewDto = new ReviewresponseDTO
                    {
                        Id = review.Id,
                        ProductId = review.ProductId,
                        NameUser = userName.Name,
                        Rating = review.Rating,
                        Comment = review.Comment
                    };
                    reviewResponse.Add(reviewDto);
                }

                var responseDTO = new getAllReviewResponseDTO
                {
                    review = reviewResponse,
                    TotalItems = totalItems,
                    PageSize = pageSize,
                    CurrentPage = pageNumber,
                };
                response.Data = responseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
            }catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<List<ReviewUserResponseDTO>>> getReviewByProductId(int productId)
        {
            var response = new StatusResponse<List<ReviewUserResponseDTO>>();
            try
            {
                var reviews = await _reviewRepository.Get().Where(x => x.ProductId == productId).ToListAsync();
                if (reviews == null)
                {
                    response.statusCode = HttpStatusCode.OK;
                    response.Errormessge = "This product has no reviews.";
                    return response;
                }

                var reviewDTOs = new List<ReviewUserResponseDTO>();
                foreach (var review in reviews)
                {
                    var user = await _userRepository.GetById(review.UserId);
                    var reviewDto = new ReviewUserResponseDTO
                    {
                        NameUser = user.Name,
                        ImageUrl = user.AvatarUrl,
                        ProductId = review.ProductId,
                        Rating = review.Rating,
                        Comment = review.Comment
                    };
                    reviewDTOs.Add(reviewDto);
                }
                response.Data = reviewDTOs;
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
