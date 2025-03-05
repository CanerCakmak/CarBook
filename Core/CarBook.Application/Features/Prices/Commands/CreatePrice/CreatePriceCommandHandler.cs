using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Prices.Commands.CreatePrice
{
    public class CreatePriceCommandHandler : IRequestHandler<CreatePriceCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public CreatePriceCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(CreatePriceCommandRequest request, CancellationToken cancellationToken)
        {
            Pricing p = new(request.Name);
            await _unitOfWork.GetWriteRepository<Pricing>().AddAsync(p);

            await _unitOfWork.SaveAsync();
        }
    }
}
