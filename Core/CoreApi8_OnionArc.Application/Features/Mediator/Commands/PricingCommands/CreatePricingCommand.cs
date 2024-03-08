using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public string? Name { get; set; }
    }
}