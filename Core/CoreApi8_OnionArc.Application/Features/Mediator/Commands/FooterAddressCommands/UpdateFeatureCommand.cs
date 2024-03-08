using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Commands.FooterAddress
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int FooterAddressID { get; set; }
        public string? Description { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}