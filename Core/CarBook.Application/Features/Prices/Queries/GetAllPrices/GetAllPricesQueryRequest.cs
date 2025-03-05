using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Prices.Queries.GetAllPrices
{
    public class GetAllPricesQueryRequest : IRequest<IList<GetAllPricesQueryResponse>>
    {
    }
}
