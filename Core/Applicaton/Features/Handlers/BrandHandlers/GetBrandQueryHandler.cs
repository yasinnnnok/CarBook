﻿using Applicaton.Features.Results.BannerResult;
using Applicaton.Features.Results.BrandResults;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {

        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
             BrandId = x.BrandId,
             Name = x.Name
            }
                ).ToList();
        }


    }
}
