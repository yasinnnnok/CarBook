using Applicaton.Features.Mediator.Commands.FeatureCommands;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FeatureId);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);



        }
    }
}
