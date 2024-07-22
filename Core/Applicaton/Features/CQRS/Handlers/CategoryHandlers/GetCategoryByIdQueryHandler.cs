using Applicaton.Features.CQRS.Queries.CategoryQueries;
using Applicaton.Features.CQRS.Results.CategoryResults;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = values.CategoryId,
                Name = values.Name
            };
        }
    }
}
