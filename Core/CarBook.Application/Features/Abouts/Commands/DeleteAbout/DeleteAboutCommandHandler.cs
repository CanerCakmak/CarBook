using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.DeleteAbout
{
    public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAboutCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<About>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
