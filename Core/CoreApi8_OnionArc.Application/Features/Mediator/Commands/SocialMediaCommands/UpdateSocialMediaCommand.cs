using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class UpdateSocialMediaCommand : IRequest
    {
        public int SocialMediaID { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? IconUrl { get; set; }
    }
}