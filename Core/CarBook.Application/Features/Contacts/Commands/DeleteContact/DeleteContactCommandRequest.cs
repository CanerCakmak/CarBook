using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Commands.DeleteContact
{
    public class DeleteContactCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteContactCommandRequest(int id)
        {
            Id = id;
        }
    }
}
