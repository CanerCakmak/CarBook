using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Car : BaseEntity
    {
        public Car()
        {
            
        }
        public Car(string Model, string CoverImagePath, int Mileage, string Transmission, int SeatCount, int Luggage, string Fuel, string BigImagePath, int BrandId)
        {
            this.Model = Model;
            this.CoverImagePath = CoverImagePath;
            this.Mileage = Mileage;
            this.Transmission = Transmission;
            this.SeatCount = SeatCount;
            this.Luggage = Luggage;
            this.Fuel = Fuel;
            this.BigImagePath = BigImagePath;
            this.BrandId = BrandId;
        }
        public string Model { get; set; }
        public string CoverImagePath { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public int SeatCount { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImagePath { get; set; }



        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<CarPricing> CarPricings { get; set; }
        public ICollection<CarFeature> CarFeatures { get; set; }
        public ICollection<CarDescription> CarDescriptions { get; set; }
    }
}
