﻿using Applicaton.Features.Commands.CarCommand;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.Fuel = command.Fuel;
            values.Transmisson = command.Transmission;
            values.BigImageUrl = command.BigImageUrl;
            values.BrandId = command.BrandID;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Km = command.Km;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            values.Seat = command.Seat;
            await _repository.UpdateAsync(values);
        }

    }
}
