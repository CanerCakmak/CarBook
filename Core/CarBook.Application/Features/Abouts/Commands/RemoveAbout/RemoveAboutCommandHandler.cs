using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.RemoveAbout
{
    public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveAboutCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<About>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
