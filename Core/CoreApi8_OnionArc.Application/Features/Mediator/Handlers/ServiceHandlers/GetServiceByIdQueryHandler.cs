using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Queries.ServiceQueries;
using CoreApi8_OnionArc.Application.Features.Mediator.Result.ServiceResults;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;
using MediatR;

namespace CoreApi8_OnionArc.Application.Services.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceID,
                Title = values.Title,
                Description = values.Description,
                IconUrl = values.IconUrl
            };
        }
    }
}