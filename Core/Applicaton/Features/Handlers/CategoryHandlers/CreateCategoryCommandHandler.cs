﻿using Applicaton.Features.Commands.CategoryCommand;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreateAsync(new Category
            {
                Name = command.Name
            });
        }
    }
}
