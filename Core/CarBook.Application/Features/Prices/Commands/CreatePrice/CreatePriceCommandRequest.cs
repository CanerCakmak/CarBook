﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Prices.Commands.CreatePrice
{
    public class CreatePriceCommandRequest : IRequest
    {
        public string Name{ get; set; }
    }
}
