using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Queries.GetAllTestimonials
{
    public class GetAllTestimonialsQueryResponse
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImagePath { get; set; }
    }
}
