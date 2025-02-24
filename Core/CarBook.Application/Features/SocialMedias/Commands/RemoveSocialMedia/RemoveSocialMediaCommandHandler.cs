using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.RemoveSocialMedia
{
    public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveSocialMediaCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<SocialMedia>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
