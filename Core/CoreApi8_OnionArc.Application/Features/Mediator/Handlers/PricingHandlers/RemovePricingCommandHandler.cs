using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.PricingCommands;

namespace CoreApi8_OnionArc.Application.Pricings.Mediator.Handlers.PricingHandlers
{
    public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public RemovePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}