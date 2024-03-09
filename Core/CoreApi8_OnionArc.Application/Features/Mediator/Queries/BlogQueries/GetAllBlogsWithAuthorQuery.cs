using CoreApi8_OnionArc.Application.Features.Mediator.Result.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
    {
    }
}
