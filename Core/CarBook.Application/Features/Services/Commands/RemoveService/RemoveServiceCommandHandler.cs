using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Commands.RemoveService
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveServiceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveServiceCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Service>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
