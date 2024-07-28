using Applicaton.Features.Mediator.Commands.FeatureCommands;
using Applicaton.Features.Mediator.Commands.FooaterAdressCommands;
using Applicaton.Features.Mediator.Handlers.FeatureHandlers;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Handlers.FooterAdressHandlers
{

    public class RemoveFooaterAdressCommandHandler : IRequestHandler<RemoveFooterAdressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public RemoveFooaterAdressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}

