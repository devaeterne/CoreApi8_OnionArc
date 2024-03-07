using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Command.CarCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CarID);
            values.Fuel = request.Fuel;
            values.Trasmission = request.Trasmission;
            values.BigImageUrl = request.BigImageUrl;
            values.BrandID = request.BrandID;
            values.CoverIMGUrl = request.CoverIMGUrl;
            values.Millage = request.Millage;
            values.Luggage = request.Luggage;
            values.Model = request.Model;
            values.Seat = request.Seat;
            await _repository.UpdateAsync(values);
        }
    }
}