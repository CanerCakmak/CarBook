using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarPricing : BaseEntity
    {
        public CarPricing()
        {
            
        }
        public CarPricing(decimal Amount, int CarId, int PricingId)
        {
            this.Amount = Amount;
            this.CarId = CarId;
            this.PricingId = PricingId;
        }
        public decimal Amount { get; set; }


        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
    }
}
