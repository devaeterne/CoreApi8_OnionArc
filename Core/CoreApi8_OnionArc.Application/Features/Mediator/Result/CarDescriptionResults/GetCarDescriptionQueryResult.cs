using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.CarDescriptionResults
{
    public class GetCarDescriptionQueryResult
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string Details { get; set; }
    }
}
