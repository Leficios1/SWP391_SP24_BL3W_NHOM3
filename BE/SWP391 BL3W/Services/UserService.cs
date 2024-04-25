using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System.Net;

namespace SWP391_BL3W.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _baseRepository;
        private readonly IMapper _mapper;

        public UserService(IBaseRepository<User> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<StatusResponse<UserResponseDto>> CreateUser(CreateUserDTO user)
        {
            try
            {
                var response = new StatusResponse<UserResponseDto>();
                if (await CheckEmailExist(user.Email) || await CheckPhoneExist(user.phone))
                {
                    response.statusCode = HttpStatusCode.BadRequest;
                    response.Errormessge = "Email or Phone existed.";
                    return response;
                }
                if (user.RoleId == 0)
                {
                    user.RoleId = 2;
                }
                var createUser = _mapper.Map<User>(user);
                createUser.AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg";
                await _baseRepository.AddAsync(createUser);
                await _baseRepository.SaveChangesAsync();
                var result = await _baseRepository.Get().OrderBy(x => x.Id).Include(x => x.Role).LastAsync();
                var returned = _mapper.Map<UserResponseDto>(result);
                response.Data = returned;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<bool> CheckEmailExist(string email)
        {
            var result = await _baseRepository.FindOne(x => x.Email.ToLower().Trim() == email.Trim().ToLower());
            if (result != null)
            {
                return true;
            }
            else
                return false;
        }

        private async Task<bool> CheckPhoneExist(string phone)
        {
            var result = await _baseRepository.FindOne(x => x.phone.Trim() == phone.Trim());
            if (result != null)
            {
                return true;
            }
            else
                return false;
        }

        public async Task<IActionResult> EditAvater(string link, int userId)
        {
            var user = await _baseRepository.Get().FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null) return new BadRequestObjectResult("Not Found user!");
            user.AvatarUrl = link.Replace("%2F", "/");
            _baseRepository.Update(user);
            await _baseRepository.SaveChangesAsync();
            return new OkObjectResult("Edit sucessfully");
        }

        public async Task<StatusResponse<UserResponseDto>> GetUser(int id)
        {
            var response = new StatusResponse<UserResponseDto>();
            var user = await _baseRepository.GetById(id);
            if (user == null)
            {
                response.statusCode = HttpStatusCode.NotFound;
                response.Errormessge = "Not Found user";
                return response;
            }
            var userResponseDto = _mapper.Map<UserResponseDto>(user);
            response.Data = userResponseDto;
            response.statusCode = HttpStatusCode.OK;
            response.Errormessge = "Succesful";
            return response;
        }

        public async Task<StatusResponse<GetAllUserResponseDTO>> GetUsers(int? pageNumber, int? pageSize)
        {
            var response = new StatusResponse<GetAllUserResponseDTO>();
            try
            {
                pageNumber ??= 1;
                pageSize ??= 15;

                if (pageNumber <= 0 || pageSize <= 0)
                {
                    response.statusCode = HttpStatusCode.BadRequest;
                    response.Errormessge = "Page not found!";
                    return response;
                }
                var totalUsers = await _baseRepository.Get().CountAsync();
                var totalPages = (int)Math.Ceiling((double)totalUsers / pageSize.Value);

                var users = await _baseRepository.Get()
                    .Include(x => x.Role)
                    .OrderBy(u => u.Id)
                    .Skip((pageNumber.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .AsNoTracking()
                    .ToListAsync();

                var userDtos = users.Select(u => new UserResponseDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    phone = u.phone,
                    DateOfBirth = u.DateOfBirth,
                    AvatarUrl = u.AvatarUrl,
                    Gender = u.Gender,
                    status = u.status,
                    RoleId = u.RoleId
                }).ToList();

                var responseDTO = new GetAllUserResponseDTO
                {
                    Result = userDtos,
                    TotalPages = totalPages,
                    CurrentPage = pageNumber.Value,
                    PageSize = pageSize.Value,
                    TotalItems = totalUsers
                };

                response.Data = responseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successfully fetched users.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<UserResponseDto>> UpdateUser(UpdateUserDTO user)
        {
            var response = new StatusResponse<UserResponseDto>();
            var existedUser = await _baseRepository.GetById(user.Id);
            if (existedUser != null)
            {
                existedUser.DateOfBirth = user.DateOfBirth;
                existedUser.Gender = user.Gender;
                existedUser.Name = user.Name;
                existedUser.phone = user.Phone;
                existedUser.Email = user.Email;
                existedUser.status = user.Status;
                _baseRepository.Update(existedUser);
                await _baseRepository.SaveChangesAsync();
                var map = _mapper.Map<UserResponseDto>(existedUser);
                response.Data = map;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Update Successful";
                return response;
            }
            else
            {
                response.statusCode = HttpStatusCode.NotFound;
                response.Errormessge = "Not Found user";
                return response;
            }
        }
    }
}
