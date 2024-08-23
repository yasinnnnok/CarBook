using Applicaton.Features.Mediator.Queries.SocialMediaQueries;
using Applicaton.Features.Mediator.Results.SocialMediaResult;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Carbook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetServiceQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Name = x.Name,
                SocialMediaID = x.SocialMediaId,
                Url = x.Url,
                Icon = x.Icon
            }).ToList();
        }
    }
}
