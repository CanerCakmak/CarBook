using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Banners.Commands.DeleteBanner
{
    public class DeleteBannerCommandHandler : IRequestHandler<DeleteBannerCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBannerCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteBannerCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Banner>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
