using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Queries.GetFooterById
{
    public class GetFooterByIdQueryRequest : IRequest<GetFooterByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetFooterByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
