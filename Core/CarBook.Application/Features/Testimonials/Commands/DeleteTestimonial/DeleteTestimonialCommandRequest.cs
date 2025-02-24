using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Commands.DeleteTestimonial
{
    public class DeleteTestimonialCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteTestimonialCommandRequest(int id)
        {
            Id = id;
        }
    }
}
