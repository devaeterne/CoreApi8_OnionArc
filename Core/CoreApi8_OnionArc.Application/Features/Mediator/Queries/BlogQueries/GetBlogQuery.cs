using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.BlogResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery : IRequest<List<GetBlogQueryResult>>
    {
    }
}
