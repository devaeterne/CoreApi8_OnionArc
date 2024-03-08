using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.PricingResults;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}