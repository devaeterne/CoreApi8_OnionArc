using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Features.Mediator.Commands.ReviewCommands;
using CoreApi8_OnionArc.Application.Interfaces;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class CreateReviewHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<Review> _repository;
        public CreateReviewHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Review
            {
                CustomerImage = request.CustomerImage,
                CarID = request.CarID,
                Comment = request.Comment,
                CustomerName = request.CustomerName,
                RaytingValue = request.RaytingValue,
                ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString())
            });
        }
    }
}
