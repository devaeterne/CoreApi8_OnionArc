using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Command.CarCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.Fuel = command.Fuel;
            values.Trasmission = command.Trasmission;
            values.BigImageUrl = command.BigImageUrl;
            values.BrandID = command.BrandID;
            values.CoverIMGUrl = command.CoverIMGUrl;
            values.Millage = command.Millage;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            values.Seat = command.Seat;
            await _repository.UpdateAsync(values);
        }
    }
}