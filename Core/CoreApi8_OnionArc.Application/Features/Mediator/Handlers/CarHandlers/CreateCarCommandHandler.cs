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
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = request.BigImageUrl,
                Luggage = request.Luggage,
                Millage = request.Millage,
                Model = request.Model,
                Seat = request.Seat,
                Trasmission = request.Trasmission,
                CoverIMGUrl = request.CoverIMGUrl,
                BrandID = request.BrandID,
                Fuel = request.Fuel

            });
        }
    }
}