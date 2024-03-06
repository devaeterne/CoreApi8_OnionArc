using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.FeatureResults
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureID { get; set; }
        public string? FeatureName { get; set; }
    }
}