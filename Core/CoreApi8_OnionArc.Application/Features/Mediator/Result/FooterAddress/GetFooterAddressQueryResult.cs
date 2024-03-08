using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.FooterAddress
{
    public class GetFooterAddressQueryResult
    {
        public int FooterAddressID { get; set; }
        public string? Description { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}