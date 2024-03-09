using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.CarFeatureCommands;
using CoreApi8_OnionArc.Application.Interfaces.CarFeatureInterfaces;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;
        public UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToFalse(request.Id);
            // return Task.CompletedTask;
        }
    }
}
