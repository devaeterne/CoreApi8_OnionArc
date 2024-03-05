using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Command.CarCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Luggage = command.Luggage,
                Millage = command.Millage,
                Model = command.Model,
                Seat = command.Seat,
                Trasmission = command.Trasmission,
                CoverIMGUrl = command.CoverIMGUrl,
                BrandID = command.BrandID,
                Fuel = command.Fuel
            });
        }
    }
}