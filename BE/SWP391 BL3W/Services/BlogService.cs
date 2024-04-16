using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.DTO.Response;
using SWP391_BL3W.Repository.Interface;
using SWP391_BL3W.Services.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SWP391_BL3W.Services
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Blog> _baseRepository;
        private readonly SWPContext _context;

        public BlogService(IMapper mapper, SWPContext context, IBaseRepository<Blog> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
            _context = context;
        }

        public async Task<StatusResponse<BlogsDTO>> CreateBlogAsync(BlogsDTO dto)
        {
            var response = new StatusResponse<BlogsDTO>();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    var blogEntity = _mapper.Map<BlogsDTO, Blog>(dto);
                    await _baseRepository.AddAsync(blogEntity);
                    await _baseRepository.SaveChangesAsync();
                    await transaction.CommitAsync();
                    var createdDto = _mapper.Map<Blog, BlogsDTO>(blogEntity);

           
                  
                        response.Data = dto;
                        response.statusCode = HttpStatusCode.Created;
                        response.Errormessge = "Create Successful";
                    return response;
                }
                catch (Exception ex)
                {
                    response.statusCode = HttpStatusCode.InternalServerError;
                    response.Errormessge = $"Error: {ex.Message}";
                    return response;
                }

            }
               
        }

        public async Task<StatusResponse<BlogsDTO>> DeleteBlogAsync(int id)
        {
            var response = new StatusResponse<BlogsDTO>();
            using (var transaction = _context.Database.BeginTransaction())
            try
            {
                var blogEntity = await _baseRepository.GetById(id);

                if (blogEntity == null)
                {

                        response.Data = null;
                        response.statusCode = HttpStatusCode.NotFound;
                        response.Errormessge = "Blog not found";
                        return response;
                    } 

                _baseRepository.Delete(blogEntity);
                await _baseRepository.SaveChangesAsync();
                    await transaction.CommitAsync();

                    var responseDTO = new BlogsDTO
                    {
                        Id = blogEntity.Id,
                        Title = blogEntity.Title,
                        Content = blogEntity.content,
                        ImageUrl = blogEntity.ImageUrl,

                    };
                    response.Data = responseDTO;
                    response.statusCode = HttpStatusCode.OK;
                    response.Errormessge = null;
                    return response;
                }
                catch (Exception ex)
                {
                    response.statusCode = HttpStatusCode.InternalServerError;
                    response.Errormessge = ex.Message;
                    response.Data = null;
                    return response;
                }
        }

        public async Task<StatusResponse<BlogsResponseDTO>> GetAllBlogsAsync(int? size, int? page)
        {
            var response = new StatusResponse<BlogsResponseDTO>();
            try
            {
                int pageSize = size ?? 10;
                int pageNumber = page ?? 1;
                List<Blog> allBlogs = await _context.Blogs.ToListAsync();
                int totalItems = allBlogs.Count;
                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                var blogsForPage = allBlogs
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new BlogsDTO
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.content,
                    ImageUrl = p.ImageUrl,
                    
                }).ToList();
                var responseDTO = new BlogsResponseDTO
                {
                    TotalPages = totalPages,
                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                    TotalItems = totalItems
                };
                response.Data = responseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Get all Blogs with pagination successfully.";
               
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
                response.Data = null;
                return response;
            }
            return response;
        }

        public async Task<StatusResponse<BlogsResponseDTO>> GetAllBlogsAsync()
        {
            var response = new StatusResponse<BlogsResponseDTO>();
            try
            {
                List<Blog> allBlogs = await _context.Blogs.ToListAsync();

                var blogsDtoList = allBlogs.Select(blog => _mapper.Map<Blog, BlogsDTO>(blog)).ToList();

                response.Data = new BlogsResponseDTO
                {
                    Blogs = blogsDtoList,
                    TotalItems = blogsDtoList.Count
                };
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Get all blogs successfully.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = $"Error: {ex.Message}";
            }

            return response;
        }

        public async Task<StatusResponse<BlogDetailsResponseDTO>> GetBlogByIdAsync(int id)
        {
            var response = new StatusResponse<BlogDetailsResponseDTO>();
            try
            {
                var product = await _context.Blogs
                    .Include(p => p.User)
                    .Include(p => p.CategoryBlog)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (product == null)
                {
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Blogs not found.";
                    return response;
                }
                var BlogsResponseDTO = new BlogDetailsResponseDTO
                {
                    Blog = new BlogsDTO
                    {
                        Id = product.Id,
                        Title = product.Title,
                        Content = product.content,
                        CategoryBlogID = product.CategoryBlogID,
                    },
                    Category = new CategoryBlogDTO
                    {
                        Id = product.CategoryBlog.Id,
                        Name = product.CategoryBlog.Name,
                 
                    },
                    User = new UserDTO
                    {
                        Id = product.User.Id,
                        Name= product.User.Name,
                        AvatarUrl = product.User.AvatarUrl,
                        DateOfBirth = product.User.DateOfBirth,
                        Email = product.User.Email,
                        Gender = product.User.Gender,
                        phone = product.User.phone,
                        status = product.User.status,
                       
                        
                    },
          
                };

                response.Data = BlogsResponseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Successful";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.BadRequest;
                response.Errormessge = ex.Message;
                response.Data = null;
            }

            return response;
        }

        public async Task<StatusResponse<BlogsResponseDTO>> UpdateBlogAsync(int id, UpdateBlogDTO dto)
        {
            var response = new StatusResponse<BlogsResponseDTO>();
            var existedBlogs = await _baseRepository.GetById(dto.Id);
            if (existedBlogs != null)
            {
                existedBlogs.Title = dto.Title;
                existedBlogs.content = dto.Content;
                existedBlogs.ImageUrl = dto.ImageUrl;
                existedBlogs.UserId = dto.UserId;
                
                _baseRepository.Update(existedBlogs);
                await _baseRepository.SaveChangesAsync();
              
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
