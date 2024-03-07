using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Command.CategoryCommands
{
    public class CreateCategoryCommand : IRequest
    {
        public string? Name { get; set; }
    }
}