﻿using Applicaton.Features.Results.AboutResults;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Applicaton.Features.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetAboutQueryResult
            {
                AboutId = x.AboutId,
                Description= x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl

            }).ToList();

        }

    }
}
