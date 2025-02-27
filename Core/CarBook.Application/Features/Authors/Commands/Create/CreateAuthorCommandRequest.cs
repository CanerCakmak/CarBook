using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommandRequest : IRequest
    {
        public int Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
