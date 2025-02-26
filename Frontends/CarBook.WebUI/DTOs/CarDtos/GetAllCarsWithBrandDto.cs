using CarBook.WebUI.DTOs.BrandDtos;

namespace CarBook.WebUI.DTOs.CarDtos
{
    public class GetAllCarsWithBrandDto
    {
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
