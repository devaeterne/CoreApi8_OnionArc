using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Queries.CarQueries;
using CoreApi8_OnionArc.Application.Features.CQRS.Result.CarResult;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CoverIMGUrl = values.CoverIMGUrl,
                Fuel = values.Fuel,
                CarID = values.CarID,
                Trasmission = values.Trasmission,
                Seat = values.Seat,
                Model = values.Model,
                Millage = values.Millage,
                Luggage = values.Luggage
            };
        }
    }
}