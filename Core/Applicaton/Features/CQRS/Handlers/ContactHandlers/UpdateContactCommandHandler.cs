using Applicaton.Features.CQRS.Commands.ContactCommands;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactId);
            values.Name = command.Name;
            values.Email = command.Email;
            values.Message = command.Message;
            values.SenDate = command.SenDate;
            values.Subject = command.Subject;
            await _repository.UpdateAsync(values);
        }
    }
}
