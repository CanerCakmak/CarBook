using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Banners.Commands.CreateBanner
{
    public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBannerCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateBannerCommandRequest request, CancellationToken cancellationToken)
        {
            Banner banner = new(request.Title, request.Description, request.VideoDescription, request.VideoUrl);

            await _unitOfWork.GetWriteRepository<Banner>().AddAsync(banner);

            await _unitOfWork.SaveAsync();
        }
    }
}
