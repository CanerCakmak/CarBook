using CarBook.Application.Bases;
using CarBook.Application.Features.Auth.Exceptions;
using CarBook.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistEsception();
            
            return Task.CompletedTask;
        }

        public Task EmailOrPasswordShouldNotBeInvalid(User? user, bool checkPassword) 
        {
            if (user is null || !checkPassword) throw new EmailOrPasswordShouldNotBeInvalidException();

            return Task.CompletedTask;
        }

        public Task RefreshTokenShouldNotBeExpired(DateTime? expiryDate)
        {
            if (expiryDate <= DateTime.Now) throw new RefreshTokenShouldNotBeExpiredException();

            return Task.CompletedTask;
        }
    }
}
