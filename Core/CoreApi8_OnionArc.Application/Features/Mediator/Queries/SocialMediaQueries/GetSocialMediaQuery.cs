using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.FeatureResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.SocialMediaResults;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}