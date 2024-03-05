using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Command.CarCommands
{
    public class RemoveCarCommand
    {
        public int Id { get; set; }

        public RemoveCarCommand(int id)
        {
            Id = id;
        }
    }
}