﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.StatisticsResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountQuery : IRequest<GetCarCountQueryResult>
    {
    }
}
