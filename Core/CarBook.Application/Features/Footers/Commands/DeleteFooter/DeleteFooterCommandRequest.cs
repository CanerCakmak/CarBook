using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Commands.DeleteFooter
{
    public class DeleteFooterCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteFooterCommandRequest(int id)
        {
            Id = id;
        }
    }
}
