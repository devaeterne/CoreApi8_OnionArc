using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.CarFeatureCommands;
using CoreApi8_OnionArc.Application.Interfaces.CarFeatureInterfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateCarFeatureByCar(new CarFeature
            {
                Available = false,
                CarID = request.CarID,
                FeatureID = request.FeatureID
            });
        }
    }
}
