using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Command.BrandCommands
{
    public class UpdateBrandCommand : IRequest
    {
        public int BrandID { get; set; }
        public string? BrandName { get; set; }
    }
}