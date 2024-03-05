using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Result.CategoryResult;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryByIdQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryByIdQueryResult
            {
                CategoryID = x.CategoryID,
                Name = x.Name
            }).ToList();
        }
    }
}