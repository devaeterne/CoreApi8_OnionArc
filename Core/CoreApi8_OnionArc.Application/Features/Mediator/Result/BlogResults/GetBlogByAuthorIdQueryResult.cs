using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.BlogResults
{
    public class GetBlogByAuthorIdQueryResult
    {
        public int BlogID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorID { get; set; }
    }
}
