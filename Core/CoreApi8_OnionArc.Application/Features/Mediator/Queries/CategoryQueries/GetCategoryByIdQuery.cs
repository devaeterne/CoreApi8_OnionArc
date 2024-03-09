using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.CategoryResult;
using MediatR;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}