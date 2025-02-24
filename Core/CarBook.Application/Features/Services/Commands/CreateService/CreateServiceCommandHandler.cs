using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateServiceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        public async Task Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            Service service = new(request.Title, request.Description, request.IconPath);

            await _unitOfWork.GetWriteRepository<Service>().AddAsync(service);

            await _unitOfWork.SaveAsync();
        }
    }
}
