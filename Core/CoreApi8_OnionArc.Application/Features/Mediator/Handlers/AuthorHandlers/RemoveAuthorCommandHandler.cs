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
    public class RemovePricingCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public RemovePricingCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
