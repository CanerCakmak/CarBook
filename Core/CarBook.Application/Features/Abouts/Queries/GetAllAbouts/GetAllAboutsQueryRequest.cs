using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Queries.GetAllAbouts
{
    public class GetAllAboutsQueryRequest : IRequest<IList<GetAllAboutsQueryResponse>>
    {
    }
}
