using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature : BaseEntity
    {
        public bool Available { get; set; }


        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid FeatureID { get; set; }
        public Feature Feature { get; set; }
    }
}
