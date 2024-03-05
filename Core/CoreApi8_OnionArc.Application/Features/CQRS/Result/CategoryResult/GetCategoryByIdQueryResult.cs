using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Result.CategoryResult
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }
    }
}