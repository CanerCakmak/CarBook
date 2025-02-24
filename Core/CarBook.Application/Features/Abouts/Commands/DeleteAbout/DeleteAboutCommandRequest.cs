using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.DeleteAbout
{
    public class DeleteAboutCommandRequest : IRequest
    {
        
        public int Id { get; set; }
    }
}
