using Applicaton.Features.Mediator.Queries.FooterAdressQueries;
using Applicaton.Features.Mediator.Results.FooterAdressResults;
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
    public class GetFooterAdressQueryHandler : IRequestHandler<GetFooterAdressQuery, List<GetFooterAdressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAdressQueryResult>> Handle(GetFooterAdressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetFooterAdressQueryResult{
               Adress=x.Adress,
               Description=x.Description,
               Email=x.Email,
               FooterAdressId=x.FooterAdressId,
               Phone=x.Phone

            }).ToList();
        }
    }
}
