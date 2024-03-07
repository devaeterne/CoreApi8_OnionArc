using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.CarQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CarResult;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
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