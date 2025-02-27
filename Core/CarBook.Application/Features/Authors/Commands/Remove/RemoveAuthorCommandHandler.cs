using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.RemoveAuthor
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveAuthorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<About>().HardDeleteByIdAsync(request.Id);
            await _unitOfWork.SaveAsync();
        }
    }
}
