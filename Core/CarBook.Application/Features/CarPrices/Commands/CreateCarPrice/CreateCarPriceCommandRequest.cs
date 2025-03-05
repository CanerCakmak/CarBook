using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CarPrices.Commands.CreateCarPrice
{
    public class CreateCarPriceCommandRequest : IRequest
    {
        public decimal Amount { get; set; }
        public int CarId { get; set; }
        public int PricingId { get; set; }
    }
}
