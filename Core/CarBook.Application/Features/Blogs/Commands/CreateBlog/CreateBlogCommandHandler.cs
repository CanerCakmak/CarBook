using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public CreateBlogCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            Blog blog = new(request.Title, request.CoverImagePath, request.AuthorId);

            await _unitOfWork.GetWriteRepository<Blog>().AddAsync(blog);

            if(await _unitOfWork.SaveAsync() > 0)
            {
                foreach (var item in request.CategoryIds)
                {
                    await _unitOfWork.GetWriteRepository<BlogCategory>().AddAsync(new()
                    {
                        BlogId = blog.Id,
                        CategoryId = item
                    });
                }

                await _unitOfWork.SaveAsync();
            }
            
        }
    }
}
