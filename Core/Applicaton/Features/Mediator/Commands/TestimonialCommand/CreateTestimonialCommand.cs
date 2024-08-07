using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Commands.TestimonialCommand
{
    public class CreateTestimonialCommand:IRequest
    {
             public string Name { get; }
        public string Title { get; }
        public string Comment { get; }
        public string ImageUrl { get; }
    }
}
