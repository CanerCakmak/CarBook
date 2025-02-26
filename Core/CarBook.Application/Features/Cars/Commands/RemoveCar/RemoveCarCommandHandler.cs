using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Commands.RemoveCar
{
    public class RemoveCarCommandHandler : IRequestHandler<RemoveCarCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveCarCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Car>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
