using CarBook.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Exceptions
{
    public class AboutMustNotBeSameException : BaseExceptions
    {
        public AboutMustNotBeSameException() : base("Hakkında başlığı zaten var!") { }

    }
}
