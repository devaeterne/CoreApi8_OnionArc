using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int FeatureID { get; set; }
        public Feature Feature { get; set; }
        public bool Availablea { get; set; }
    }
}