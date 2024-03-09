using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CarPricingResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.CarPricingQueries
{
	public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
	{
	}
}
