﻿using CarBook.WebUI.DTOs.BrandDtos;

namespace CarBook.WebUI.DTOs.CarDtos
{
    public class GetAllCarsWithBrandDto
    {
        public string Model { get; set; }
        public string CoverImagePath { get; set; }
        public BrandDto Brand { get; set; }
    }
}
