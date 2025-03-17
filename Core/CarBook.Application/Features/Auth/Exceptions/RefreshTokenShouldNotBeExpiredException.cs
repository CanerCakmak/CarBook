using CarBook.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException : BaseExceptions
    {

        public RefreshTokenShouldNotBeExpiredException() : base("Oturum Süresi sona ermiştir! Lütfen tekrar giriş yapınız!")
        {
        }
    }
}
