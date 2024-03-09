using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.LocationResults;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
