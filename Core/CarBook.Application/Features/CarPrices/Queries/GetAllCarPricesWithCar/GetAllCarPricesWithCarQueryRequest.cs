using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar
{
    public class GetAllCarPricesWithCarQueryRequest : IRequest<IList<GetAllCarPricesWithCarQueryResponse>>
    {
    }
}
