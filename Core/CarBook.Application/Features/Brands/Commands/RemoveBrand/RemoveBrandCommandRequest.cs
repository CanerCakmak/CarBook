using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.RemoveBrand
{
    public class RemoveBrandCommandRequest : IRequest
    {
        public int Id { get; set; }

        public RemoveBrandCommandRequest(int id)
        {
            Id = id;
        }
    }
}
