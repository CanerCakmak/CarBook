using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.CreateAbout
{
    internal class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateAboutCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            About about = new(request.Title, request.Description, request.ImagePath);
            await unitOfWork.GetWriteRepository<About>().AddAsync(about);

            await unitOfWork.SaveAsync();
        }
    }
}
