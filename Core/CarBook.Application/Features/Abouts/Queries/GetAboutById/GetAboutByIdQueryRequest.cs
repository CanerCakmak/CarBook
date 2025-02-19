using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Queries.GetAboutById
{
    public class GetAboutByIdQueryRequest : IRequest<GetAboutByIdQueryResponse>
    {
        public GetAboutByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
