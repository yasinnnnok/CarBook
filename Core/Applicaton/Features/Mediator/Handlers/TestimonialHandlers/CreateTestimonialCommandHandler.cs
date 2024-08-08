﻿using Applicaton.Features.Mediator.Commands.TestimonialCommand;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;
        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Testimonial
            {
                Name = request.Name,
                Comment = request.Comment,
                ImageUrl = request.ImageUrl,
                Title = request.Title
            });
        }


        //
        //private readonly IRepository<Testimonial> _repository;
        //public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        //{
        //    _repository = repository;
        //}
        //public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        //{
        //    await _repository.CreateAsync(new Testimonial
        //    {
        //        Name = request.Name,
        //        Comment = request.Comment,
        //        ImageUrl = request.ImageUrl,
        //        Title = request.Title
        //    });
        //}
        ////

    }
}
