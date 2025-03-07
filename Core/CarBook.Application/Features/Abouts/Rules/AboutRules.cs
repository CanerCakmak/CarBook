using CarBook.Application.Bases;
using CarBook.Application.Features.Abouts.Exceptions;
using CarBook.Domain.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Rules
{
    public class AboutRules : BaseRules
    {
        public Task AboutMustNotBeSame(IList<About> abouts, string requestTitle)
        {
            if (abouts.Any(x => x.Title == requestTitle))
                throw new AboutMustNotBeSameException();

            return Task.CompletedTask;
        }
    }
}
