using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Commands.FeatureCommands
{
    public class CreateFeatureCommand : IRequest
    {
        public string? FeatureName { get; set; }
    }
}