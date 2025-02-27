using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAllAuthorsQueryRequest : IRequest<IList<GetAllAuthorsQueryResponse>>
    {
    }
}
