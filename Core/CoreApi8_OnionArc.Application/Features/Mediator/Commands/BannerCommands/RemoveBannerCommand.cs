using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Command.BannerCommands
{
    public class RemoveBannerCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}