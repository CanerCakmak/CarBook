using CarBook.Application.DTOs.BrandDtos;
using CarBook.Application.DTOs.CarDtos;
using CarBook.Application.DTOs.PricingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar
{
    public class GetAllCarPricesWithCarQueryResponse
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public PricingDto Pricing { get; set; }
        public GetAllCarPricesCarDtoResponse Car { get; set; }
    }
}
