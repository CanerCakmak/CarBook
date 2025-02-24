using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.RemoveAbout
{
    public class RemoveAboutCommandRequest: IRequest
    {
        public int Id { get; set; }
    }
}
