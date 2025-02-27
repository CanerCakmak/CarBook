using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateBlogCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var blog = _unitOfWork.GetReadRepository<Blog>().GetAsync(x => x.Id == request.Id);

            if (blog != null)
            {
                var map = _customMapper.Map<Blog, UpdateBlogCommandRequest>(request);

                var blogCategories = await _unitOfWork.GetReadRepository<BlogCategory>().GetAllAsync(x => x.BlogId == request.Id && !x.IsDeleted);

                await _unitOfWork.GetWriteRepository<BlogCategory>().HardDeleteRangeAsync(blogCategories);

                foreach (var item in request.CategoryIds)
                {
                    await _unitOfWork.GetWriteRepository<BlogCategory>().AddAsync(new()
                    {
                        BlogId = blog.Id,
                        CategoryId = item
                    });
                }
                await _unitOfWork.GetWriteRepository<Blog>().UpdateAsync(map);

                await _unitOfWork.SaveAsync();
            }
        }
    }
}
