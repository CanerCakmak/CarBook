using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Queries.GetAllFooters
{
    public class GetAllFootersQueryRequest : IRequest<IList<GetAllFootersQueryResponse>>
    {
    }
}
