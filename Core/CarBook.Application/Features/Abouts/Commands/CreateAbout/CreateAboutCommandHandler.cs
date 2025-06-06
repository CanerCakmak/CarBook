﻿using CarBook.Application.Features.Abouts.Rules;
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
    internal class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AboutRules aboutRules;

        public CreateAboutCommandHandler(IUnitOfWork unitOfWork , AboutRules aboutRules)
        {
            this.unitOfWork = unitOfWork;
            this.aboutRules = aboutRules;
        }
        public async Task<Unit> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var abouts = await unitOfWork.GetReadRepository<About>().GetAllAsync();

            await aboutRules.AboutMustNotBeSame(abouts , request.Title);

            About about = new(request.Title, request.Description, request.ImagePath);
            await unitOfWork.GetWriteRepository<About>().AddAsync(about);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
