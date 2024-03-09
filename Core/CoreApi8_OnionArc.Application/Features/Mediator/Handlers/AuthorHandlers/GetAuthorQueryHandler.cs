using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.AuthorQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.FeatureResults;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.AuthorResults;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        public GetServiceQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Name = x.Name,
                AuthorID = x.AuthorID,
                ImageUrl = x.ImageUrl,
                Description = x.Description
            }).ToList();
        }
    }
}
