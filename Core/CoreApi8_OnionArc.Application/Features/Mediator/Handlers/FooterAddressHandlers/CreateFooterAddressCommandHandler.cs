using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.FeatureCommands;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.FooterAddress;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.FooterAddressCommands
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddress
            {
                Adress = request.Adress,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
        }
    }
}