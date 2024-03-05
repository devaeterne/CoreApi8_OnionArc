using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Command.BannerCommands
{
    public class RemoveBannerCommand
    {
        public int Id { get; set; }
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}