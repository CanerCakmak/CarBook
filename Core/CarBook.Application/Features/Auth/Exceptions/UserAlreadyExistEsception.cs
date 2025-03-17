using CarBook.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistEsception : BaseExceptions
    {
        public UserAlreadyExistEsception() : base("Böyle bir kullanıcı zaten var!") { }
    }
}
