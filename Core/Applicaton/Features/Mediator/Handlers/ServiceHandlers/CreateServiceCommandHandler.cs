using Applicaton.Features.Mediator.Commands.ServiceCommands;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UdemyCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public CreatePricingCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Descripton = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title
            });
        }
    }
}
