using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Brand>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
