using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.CarFeatureResults
{
    public class GetCarFeatureByCarIdQueryResult
    {
        public int CarFeatureID { get; set; }
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
        public bool Available { get; set; }
    }
}
