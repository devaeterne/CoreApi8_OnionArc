using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.AuthorResults
{
    public class GetAuthorQueryResult
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
