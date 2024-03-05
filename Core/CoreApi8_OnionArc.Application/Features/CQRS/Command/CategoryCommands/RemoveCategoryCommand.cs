using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Command.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}