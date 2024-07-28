using Applicaton.Features.Mediator.Commands.FooaterAdressCommands;
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
    public class UpdateFooterAdressCommandHandler : IRequestHandler<UpdateFooterAdressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public UpdateFooterAdressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAdressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAdressId);
            value.Phone = request.Phone;
            value.Adress = request.Adress;
            value.Email = request.Email;
            value.Description = request.Description;
            await _repository.UpdateAsync(value);
        }
    }
}
