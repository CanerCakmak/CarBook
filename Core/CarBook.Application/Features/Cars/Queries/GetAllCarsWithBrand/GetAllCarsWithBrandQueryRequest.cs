﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetAllCarsWithBrand
{
    public class GetAllCarsWithBrandQueryRequest : IRequest<IList<GetAllCarsWithBrandQueryResponse>>
    {
    }
}
