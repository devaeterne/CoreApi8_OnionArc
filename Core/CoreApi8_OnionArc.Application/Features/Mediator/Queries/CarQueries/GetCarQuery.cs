using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CarResult;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.CarQueries
{
    public class GetCarQuery : IRequest<List<GetCarQueryResult>>
    {

    }
}