﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.PricingQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.RentACarQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.PricingResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.RentACarResults;
using CoreApi8_OnionArc.Application.Interfaces.RentACarInterfaces;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
            var results = values.Select(y => new GetRentACarQueryResult
            {
                CarId = y.CarID,
                Brand = y.Car.Brand.BrandName,
                Model = y.Car.Model,
                CoverImageUrl = y.Car.CoverIMGUrl
            }).ToList();
            return results;
        }
    }
}