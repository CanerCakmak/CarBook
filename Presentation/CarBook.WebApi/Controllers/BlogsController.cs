using CarBook.Application.Features.Blogs.Commands.CreateBlog;
using CarBook.Application.Features.Blogs.Commands.DeleteBlog;
using CarBook.Application.Features.Blogs.Commands.RemoveBlog;
using CarBook.Application.Features.Blogs.Commands.UpdateBlog;
using CarBook.Application.Features.Blogs.Queries.GetAllBlogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Blogs.Queries.GetBlogWithAuthorById;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogsController : Controller
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogsWithAuthor()
        {
            var response = await _mediator.Send(new GetAllBlogsWithAuthorQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogWithAuthorById(int id)
        {
            var response = await _mediator.Send(new GetBlogWithAuthorByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Blog Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Blog Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(DeleteBlogCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Blog Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(RemoveBlogCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Blog Başarıyla Sistemden Silindi");
        }

    }
}

