using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Commands.UpdateCar
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateCarCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Car>().GetAsync(x => x.Id == request.Id);

            if (car != null)
            {
                var map = _customMapper.Map<Car, UpdateCarCommandRequest>(request);

                await _unitOfWork.GetWriteRepository<Car>().UpdateAsync(map);
            }
        }
    }
}
