using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateSocialMediaCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            var socialmedia = await _unitOfWork.GetReadRepository<SocialMedia>().GetAsync(x=>x.Id==request.Id);

            var map = _customMapper.Map<SocialMedia,UpdateSocialMediaCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<SocialMedia>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();
        }
    }
}
