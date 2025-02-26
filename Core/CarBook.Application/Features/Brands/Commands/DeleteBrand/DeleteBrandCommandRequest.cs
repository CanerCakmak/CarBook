using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommandRequest :IRequest
    {
        public int Id { get; set; }

        public DeleteBrandCommandRequest(int id)
        {
            Id = id;
        }
    }
}
