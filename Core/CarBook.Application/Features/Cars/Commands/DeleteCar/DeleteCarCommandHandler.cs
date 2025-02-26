using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Commands.DeleteCar
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCarCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Car>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
