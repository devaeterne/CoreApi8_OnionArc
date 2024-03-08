using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.SocialMediaQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.SocialMediaResults;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.SocialMedias.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaID = values.SocialMediaID,
                Name = values.Name,
                IconUrl = values.IconUrl,
                Url = values.Url
            };
        }
    }
}