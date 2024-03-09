using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.AuthorCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public CreatePricingCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            });
        }
    }
}
