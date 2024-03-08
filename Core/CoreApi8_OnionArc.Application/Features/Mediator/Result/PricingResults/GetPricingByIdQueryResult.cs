using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.PricingResults
{
    public class GetPricingByIdQueryResult
    {
        public int PricingID { get; set; }
        public string? Name { get; set; }
    }
}