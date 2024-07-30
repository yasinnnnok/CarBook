using Applicaton.Features.Mediator.Queries.LocationQueries;
using Applicaton.Features.Mediator.Results.LocationResult;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Handlers.LocationHandler
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationtQueryResult>>
    {
        private readonly IRepository<Location> _repository;
        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetLocationtQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetLocationtQueryResult
            {
                Name = x.Name,
                LocationId=x.LocationId
                    
            }).ToList();
        }
    }
}
