using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Queries.GetAllTestimonials
{
    public class GetAllTestimonialsQueryRequest : IRequest<IList<GetAllTestimonialsQueryResponse>>
    {
    }
}
