using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;

namespace SWP391_BL3W.Services
{
    public class CartService : ICartService
    {
        private readonly IBaseRepository<Cart> _cartRepository;
        private readonly SWPContext _context;
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Product> _productRepository;
        private readonly IBaseRepository<User> _userRepository;

        public CartService(IBaseRepository<Cart> cartRepository, SWPContext context, IMapper mapper, IBaseRepository<Product> productRepository,
            IBaseRepository<User> userRepository)
        {
            _cartRepository = cartRepository;
            _context = context;
            _mapper = mapper;
            _productRepository = productRepository;
            _userRepository = userRepository;
        }

        public async Task<StatusResponse<CartResponseDTO>> createCart(CartRequestDTO dto)
        {
            var response = new StatusResponse<CartResponseDTO>();
            using (var trasaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var mapper = _mapper.Map<Cart>(dto);
                    var existingUser = await _userRepository.GetById(dto.UserId);
                    if (existingUser == null)
                    {
                        response.statusCode = HttpStatusCode.NotFound;
                        response.Errormessge = "Not Found User";
                        return response;
                    }
                    await _cartRepository.AddAsync(mapper);
                    await _cartRepository.SaveChangesAsync();
                    var result = _mapper.Map<CartResponseDTO>(mapper);
                    response.Data = result;
                    response.statusCode = HttpStatusCode.OK;
                    response.Errormessge = "Successful";
                    trasaction.Commit();
                }
                catch (Exception ex)
                {
                    trasaction.Rollback();
                    response.statusCode = HttpStatusCode.InternalServerError;
                    response.Errormessge = ex.Message;
                    return response;
                }
                return response;
            }
        }

        public async Task<StatusResponse<bool>> deleteCart(int id)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var existingCart = await _cartRepository.GetById(id);
                if (existingCart == null)
                {
                    response.statusCode= HttpStatusCode.NotFound;
                    response.Errormessge = "Not Found CartId";
                    return response;
                }
                _cartRepository.Delete(existingCart);
                await _cartRepository.SaveChangesAsync();
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                response.Data = true;
            }catch(Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                return response;
            }
            return response;
        }

        public async Task<StatusResponse<List<CartResponseDTO>>> getCartbyUserId(int userId)
        {
            var response = new StatusResponse<List<CartResponseDTO>>();
            try
            {
                var carts = await _cartRepository.Get().Where(x => x.UserId == userId).ToListAsync();
                var cartResponseDTOs = _mapper.Map<List<CartResponseDTO>>(carts);
                response.Data = cartResponseDTOs;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";

            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                return response;
            }
            return response;
        }

        public Task<StatusResponse<CartResponseDTO>> updateCart(CartUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
