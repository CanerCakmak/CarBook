using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CarPrices.Commands.CreateCarPrice
{
    public class CreateCarPriceCommandHandler : IRequestHandler<CreateCarPriceCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCarPriceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateCarPriceCommandRequest request, CancellationToken cancellationToken)
        {
            CarPricing cp = new CarPricing(request.Amount , request.CarId , request.PricingId);

            await _unitOfWork.GetWriteRepository<CarPricing>().AddAsync(cp);
            await _unitOfWork.SaveAsync();
        }
    }
}
