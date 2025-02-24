using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Commands.DeleteService
{
    public class DeleteServiceCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteServiceCommandRequest(int id)
        {
            Id = id;
        }
    }
}
