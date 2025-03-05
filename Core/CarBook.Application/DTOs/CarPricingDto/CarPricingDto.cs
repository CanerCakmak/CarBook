using CarBook.Application.DTOs.PricingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.DTOs.CarPricingDto
{
    public class CarPricingDto
    {
        public decimal Amount { get; set; }
        public PricingDto Pricing { get; set; }
    }
}
