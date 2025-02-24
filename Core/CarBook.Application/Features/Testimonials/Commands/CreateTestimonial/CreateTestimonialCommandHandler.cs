using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Commands.CreateTestimonial
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTestimonialCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            Testimonial tm = new(request.Name, request.Title, request.Comment, request.ImagePath);

            await _unitOfWork.GetWriteRepository<Testimonial>().AddAsync(tm);
            await _unitOfWork.SaveAsync();
        }
    }
}
