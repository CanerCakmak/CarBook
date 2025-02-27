using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetCarsWithBrandByCount
{
    public class GetCarsWithBrandByCountQueryRequest :IRequest<IList<GetCarsWithBrandByCountQueryResponse>>
    {
        public GetCarsWithBrandByCountQueryRequest()
        {
            
        }
        public GetCarsWithBrandByCountQueryRequest(int count)
        {
            Count = count;
        }
        public int Count { get; set; }
    }
}
