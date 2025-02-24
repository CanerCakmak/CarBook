using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.CreateSocialMedia
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateSocialMediaCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            SocialMedia sm = new(request.Name, request.Url, request.IconPath);

            await _unitOfWork.GetWriteRepository<SocialMedia>().AddAsync(sm);

            await _unitOfWork.SaveAsync();
        }
    }
}
