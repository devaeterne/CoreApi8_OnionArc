using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.TagCloudResults
{
    public class GetTagCloudByBlogIdQueryResult
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
