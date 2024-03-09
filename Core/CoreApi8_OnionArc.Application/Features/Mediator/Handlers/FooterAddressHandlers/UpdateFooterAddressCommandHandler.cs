using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.FeatureCommands;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.FooterAddress;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAddressID);
            value.Phone = request.Phone;
            value.Adress = request.Adress;
            value.Description = request.Description;
            value.Email = request.Email;
            await _repository.UpdateAsync(value);
        }
    }
}