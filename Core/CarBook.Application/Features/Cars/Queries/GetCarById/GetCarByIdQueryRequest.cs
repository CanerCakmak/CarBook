using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetCarById
{
    public class GetCarByIdQueryRequest : IRequest<GetCarByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetCarByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
