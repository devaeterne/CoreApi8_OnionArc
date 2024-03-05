using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Result.CarResult;
using CoreApi8_OnionArc.Application.Interfaces.CarInterfaces;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5CarsWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                BrandName = x.Brand.BrandName,
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