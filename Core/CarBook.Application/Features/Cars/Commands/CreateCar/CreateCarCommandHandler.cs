using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Commands.CreateCar
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public CreateCarCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            var map = _customMapper.Map<Car, CreateCarCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<Car>().AddAsync(map);

            await _unitOfWork.SaveAsync();
        }
    }
}
