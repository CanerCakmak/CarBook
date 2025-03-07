using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.CreateAbout
{
    public class CreateAboutCommandValidator : AbstractValidator<CreateAboutCommandRequest>
    {
        public CreateAboutCommandValidator()
        {
            RuleFor(x=> x.Title)
                .NotEmpty()
                .WithName("Başlık");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithName("Açıklama");
        }
    }
}
