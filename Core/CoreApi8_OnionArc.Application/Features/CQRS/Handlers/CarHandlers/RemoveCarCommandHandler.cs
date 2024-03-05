using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.CQRS.Command.CarCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public RemoveCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}