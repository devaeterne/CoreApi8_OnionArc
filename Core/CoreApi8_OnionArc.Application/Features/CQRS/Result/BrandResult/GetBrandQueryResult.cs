using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Result.BrandResult
{
    public class GetBrandQueryResult
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

    }
}