using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateServiceCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var service = await _unitOfWork.GetReadRepository<Service>().GetAsync(x=>x.Id == request.Id);

            var map = _customMapper.Map<Service, UpdateServiceCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<Service>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();
        }
    }
}
