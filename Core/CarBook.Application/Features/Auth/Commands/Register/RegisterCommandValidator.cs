using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .WithName("İsim Soyisim");

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithName("E-posta Adresi");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithName("Şifreniz");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .Equal(x => x.Password)
                .WithName("Şifre Tekrar");
        }
    }
}
