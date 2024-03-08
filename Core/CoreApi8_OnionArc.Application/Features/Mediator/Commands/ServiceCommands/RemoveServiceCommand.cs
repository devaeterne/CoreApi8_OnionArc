using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Commands.ServiceCommands
{
    public class RemoveServiceCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}