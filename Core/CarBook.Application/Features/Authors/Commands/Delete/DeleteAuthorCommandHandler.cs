using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAuthorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var blogs = await _unitOfWork.GetReadRepository<Blog>().GetAllAsync(x=> x.AuthorId == request.Id);

            await _unitOfWork.GetWriteRepository<Blog>().SoftDeleteRangeAsync(blogs);

            await _unitOfWork.GetWriteRepository<Author>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
