using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.CarPricingQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.BlogResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CarPricingResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.LocationResults;
using CoreApi8_OnionArc.Application.Interfaces.CarPricingInterfaces;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                CarPricingId = x.CarPricingID,
                Brand = x.Car.Brand.BrandName,
                CoverImageUrl = x.Car.CoverIMGUrl,
                Model = x.Car.Model,
                CarId = x.CarID
            }).ToList();
        }
    }
}
