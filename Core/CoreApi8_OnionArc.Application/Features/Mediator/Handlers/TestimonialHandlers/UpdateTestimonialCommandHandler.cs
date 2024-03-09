using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.TestimonialCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;
        public UpdatePricingCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TestimonialID);
            values.Name = request.Name;
            values.Comment = request.Comment;
            values.Title = request.Title;
            values.ImageUrl = request.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
