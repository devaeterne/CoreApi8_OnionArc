using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.CarFeatureQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.LocationQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.BlogResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CarFeatureResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.LocationResults;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Application.Interfaces.BlogInterfaces;
using CoreApi8_OnionArc.Application.Interfaces.CarFeatureInterfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;
        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeaturesByCarID(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                Available = x.Available,
                CarFeatureID = x.CarFeatureID,
                FeatureID = x.FeatureID,
                FeatureName = x.Feature.Name
            }).ToList();
        }
    }
}
