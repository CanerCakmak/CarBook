using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteAuthorCommandRequest(int id)
        {
            Id = id;
        }
    }
}
