using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string? FeatureName { get; set; }
        public List<CarFeature>? CarFeature { get; set; }
    }
}