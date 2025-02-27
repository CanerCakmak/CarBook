using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Commands.RemoveBlog
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveBlogCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var blogCategories = await _unitOfWork.GetReadRepository<BlogCategory>().GetAllAsync(x=> x.BlogId == request.Id);

            await _unitOfWork.GetWriteRepository<BlogCategory>().HardDeleteRangeAsync(blogCategories);

            await _unitOfWork.GetWriteRepository<Blog>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
