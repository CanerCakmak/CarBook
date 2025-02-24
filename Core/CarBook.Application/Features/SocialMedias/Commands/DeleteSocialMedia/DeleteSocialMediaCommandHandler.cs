using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.DeleteSocialMedia
{
    public class DeleteSocialMediaCommandHandler : IRequestHandler<DeleteSocialMediaCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSocialMediaCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<SocialMedia>().SoftDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
