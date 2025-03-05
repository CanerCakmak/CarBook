using CarBook.Application.DTOs.BrandDtos;
using CarBook.Application.DTOs.CarPricingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetCarsWithBrandByCount
{
    public class GetCarsWithBrandByCountQueryResponse
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CoverImagePath { get; set; }

        public BrandDto Brand { get; set; }
        public List<CarPricingDto> CarPricings { get; set; }
    }
}
