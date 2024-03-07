using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Command.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }
    }
}