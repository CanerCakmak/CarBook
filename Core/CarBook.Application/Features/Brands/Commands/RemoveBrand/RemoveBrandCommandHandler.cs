using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.RemoveBrand
{
    public class RemoveBrandCommandHandler : IRequestHandler<RemoveBrandCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Brand>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
