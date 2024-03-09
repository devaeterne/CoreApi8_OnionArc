using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.ServiceResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
