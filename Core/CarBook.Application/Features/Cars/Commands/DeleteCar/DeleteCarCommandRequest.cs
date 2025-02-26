using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Commands.DeleteCar
{
    public class DeleteCarCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteCarCommandRequest(int id)
        {
            Id = id;
        }
    }
}
