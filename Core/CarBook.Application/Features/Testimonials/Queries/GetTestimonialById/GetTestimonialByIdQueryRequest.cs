using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Queries.GetTestimonialById
{
    public class GetTestimonialByIdQueryRequest : IRequest<GetTestimonialByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetTestimonialByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
