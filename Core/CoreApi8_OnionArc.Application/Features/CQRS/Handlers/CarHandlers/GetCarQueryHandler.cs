using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Result.CarResult;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;
        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverIMGUrl = x.CoverIMGUrl,
                Fuel = x.Fuel,
                Millage = x.Millage,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Trasmission = x.Trasmission
            }).ToList();
        }
    }
}