using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Commad.AboutCommands
{
    public class RemoveAboutCommand
    {
        public int Id { get; set; }

        public RemoveAboutCommand(int id)
        {
            Id = id;
        }
    }
}