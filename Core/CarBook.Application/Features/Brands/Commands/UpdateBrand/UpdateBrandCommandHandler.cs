using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.UpdateBrand
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateBrandCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var brand = _unitOfWork.GetReadRepository<Brand>().GetAsync(x=>x.Id == request.Id);

            if (brand != null)
            {
                var map = _customMapper.Map<Brand, UpdateBrandCommandRequest>(request);

                await _unitOfWork.GetWriteRepository<Brand>().UpdateAsync(map);

                await _unitOfWork.SaveAsync();
            }
        }
    }
}
