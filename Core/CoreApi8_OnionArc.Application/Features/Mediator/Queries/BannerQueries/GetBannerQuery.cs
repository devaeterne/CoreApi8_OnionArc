using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.BannerResult;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.BannerQueries
{
    public class GetBannerQuery : IRequest<List<GetBannerQueryResult>>
    {

    }
}