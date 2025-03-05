using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Queries.GetAuthorById
{
    public class GetAuthorByIdQueryRequest : IRequest<GetAuthorByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetAuthorByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
