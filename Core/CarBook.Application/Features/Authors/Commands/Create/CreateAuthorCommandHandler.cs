using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateAuthorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            Author author = new(request.Name, request.ImagePath, request.Description);

            await _unitOfWork.GetWriteRepository<Author>().AddAsync(author);
            await _unitOfWork.SaveAsync();
        }
    }
}
