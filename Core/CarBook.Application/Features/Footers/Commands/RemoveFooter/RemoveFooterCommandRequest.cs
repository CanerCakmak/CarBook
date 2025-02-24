using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Commands.RemoveFooter
{
    public class RemoveFooterCommandRequest : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterCommandRequest(int id)
        {
            Id = id;
        }
    }
}
