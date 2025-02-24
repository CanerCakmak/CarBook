using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Banners.Commands.UpdateBanner
{
    public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateBannerCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateBannerCommandRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitOfWork.GetReadRepository<Banner>().GetAsync(x=>x.Id == request.Id);

            var map = _customMapper.Map<UpdateBannerCommandRequest,Banner>(banner);

            await _unitOfWork.GetWriteRepository<Banner>().UpdateAsync(banner);

            await _unitOfWork.SaveAsync();
        }
    }
}
