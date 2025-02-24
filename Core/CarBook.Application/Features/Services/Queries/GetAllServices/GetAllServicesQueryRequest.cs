using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryRequest : IRequest<IList<GetAllServicesQueryResponse>>
    {
    }
}
