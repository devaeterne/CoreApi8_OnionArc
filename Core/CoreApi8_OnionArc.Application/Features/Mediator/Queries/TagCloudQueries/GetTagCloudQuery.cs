using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.TagCloudResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
    {
    }
}
