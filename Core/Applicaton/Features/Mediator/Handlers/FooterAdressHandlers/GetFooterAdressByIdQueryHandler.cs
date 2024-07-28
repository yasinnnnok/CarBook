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
    internal class GetFooterAdressByIdQueryHandler : IRequestHandler<GetFooterAdressByIdQuery, GetFooterAdressByIdResult>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressByIdQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAdressByIdResult> Handle(GetFooterAdressByIdQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAdressByIdResult
            {Adress=value.Adress,
            Description=value.Description,
            FooterAdressId=value.FooterAdressId,
            Phone=value.Phone

            };

        }
    }
}
