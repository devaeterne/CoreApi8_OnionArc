using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.BrandResult;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }
    }
}