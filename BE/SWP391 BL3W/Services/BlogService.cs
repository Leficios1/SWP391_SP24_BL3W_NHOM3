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

        public async Task<StatusResponse<BlogsDTO>> CreateBlogAsync(BlogRequestDTO dto)
        {
            var response = new StatusResponse<BlogsDTO>();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var blogEntity = _mapper.Map<Blog>(dto);
                    await _baseRepository.AddAsync(blogEntity);
                    await _baseRepository.SaveChangesAsync();
                    var createdDto = _mapper.Map<BlogsDTO>(blogEntity);
                    response.Data = createdDto;
                    response.statusCode = HttpStatusCode.Created;
                    response.Errormessge = "Create Successful";
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    response.statusCode = HttpStatusCode.InternalServerError;
                    response.Errormessge = $"Error: {ex.Message}";
                }
                return response;
            }

        }

        public async Task<StatusResponse<bool>> DeleteBlogAsync(int id)
        {
            var response = new StatusResponse<bool>();
            try
            {
                var blogEntity = await _baseRepository.GetById(id);
                if (blogEntity == null)
                {
                    response.Data = false;
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Blog not found";
                    return response;
                }
                _baseRepository.Delete(blogEntity);
                await _baseRepository.SaveChangesAsync();
                response.Data = true;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Delete Succesful!";
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Errormessge = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<BlogsResponseDTO>> GetAllBlogsAsync(int? size, int? page)
        {
            var response = new StatusResponse<BlogsResponseDTO>();
            try
            {
                int pageSize = size ?? 15;
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
                    ImageUrl = p.ImageUrl,
                    UserId = p.UserId,
                    CategoryBlogID = p.CategoryBlogID
                }).ToList();

                var responseDTO = new BlogsResponseDTO
                {
                    Blogs = blogsForPage,
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
                return response;
            }
            return response;
        }

        public async Task<StatusResponse<BlogDetailsResponseDTO>> GetBlogByIdAsync(int id)
        {
            var response = new StatusResponse<BlogDetailsResponseDTO>();
            try
            {
                var blog = await _context.Blogs
                    .Include(p => p.CategoryBlog)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (blog == null)
                {
                    response.statusCode = HttpStatusCode.NotFound;
                    response.Errormessge = "Blogs not found.";
                    return response;
                }
                var BlogsResponseDTO = new BlogDetailsResponseDTO
                {
                    Blog = new BlogsDTO
                    {
                        Id = blog.Id,
                        Title = blog.Title,
                        Content = blog.content,
                        CategoryBlogID = blog.CategoryBlogID,
                    },
                    Category = new CategoryBlogDTO
                    {
                        Id = blog.CategoryBlog.Id,
                        Name = blog.CategoryBlog.Name,

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
            }
            return response;
        }
        public async Task<StatusResponse<BlogsResponseDTO>> UpdateBlogAsync(UpdateBlogDTO dto)
        {
            var response = new StatusResponse<BlogsResponseDTO>();
            var existedBlogs = await _baseRepository.GetById(dto.Id);
            try
            {
                if (existedBlogs != null)
                {
                    existedBlogs.Title = dto.Title;
                    existedBlogs.content = dto.Content;
                    existedBlogs.ImageUrl = dto.ImageUrl;
                    existedBlogs.UserId = dto.UserId;

                    _baseRepository.Update(existedBlogs);
                    await _baseRepository.SaveChangesAsync();
                }
                var mapper = _mapper.Map<BlogsResponseDTO>(existedBlogs);
                response.Data = mapper;
                response.statusCode = HttpStatusCode.OK;
                response.Errormessge = "Update Successful";
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

