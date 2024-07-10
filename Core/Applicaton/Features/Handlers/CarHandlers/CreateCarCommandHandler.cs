using Applicaton.Features.Commands.CarCommand;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        //
        private readonly IRepository<Car> _repository;
        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Luggage = command.Luggage,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Transmisson = command.Transmission,
                CoverImageUrl = command.CoverImageUrl,
                BrandId = command.BrandID,
                Fuel = command.Fuel
            });
        }
        //
    }
}
