using Applicaton.Features.Mediator.Queries.ServiceQuery;
using Applicaton.Features.Mediator.Results.ServiceResults;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Carbook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;
        public GetPricingByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceId,
                Description = values.Descripton,
                Title = values.Title,
                IconUrl = values.IconUrl
            };
        }
    }
}
