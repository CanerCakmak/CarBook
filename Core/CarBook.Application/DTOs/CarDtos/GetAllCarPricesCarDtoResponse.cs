using CarBook.Application.DTOs.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.DTOs.CarDtos
{
    public class GetAllCarPricesCarDtoResponse
    {
        public string Model { get; set; }
        public string CoverImagePath { get; set; }

        public BrandDto Brand{ get; set; }
    }
}
