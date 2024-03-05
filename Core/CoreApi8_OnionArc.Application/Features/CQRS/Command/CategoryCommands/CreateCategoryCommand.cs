using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Command.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string? Name { get; set; }
    }
}