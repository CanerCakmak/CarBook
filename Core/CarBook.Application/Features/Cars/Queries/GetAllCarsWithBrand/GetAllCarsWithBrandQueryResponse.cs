using CarBook.Application.DTOs.BrandDtos;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetAllCarsWithBrand
{
    public class GetAllCarsWithBrandQueryResponse
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CoverImagePath { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public int SeatCount { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImagePath { get; set; }
        public BrandDto Brand { get; set; }

    }
}
