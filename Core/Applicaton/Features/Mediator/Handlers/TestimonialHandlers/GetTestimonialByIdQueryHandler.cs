using Applicaton.Features.Mediator.Queries.TestimonialQueries;
using Applicaton.Features.Mediator.Results.TestimonialResult;
using Applicaton.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Carbook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialId = values.TestimonialId,
                Name = values.Name,
                Comment = values.Comment,
                Title= values.Title,
                ImageUrl = values.ImageUrl
            };
        }
    }
}
