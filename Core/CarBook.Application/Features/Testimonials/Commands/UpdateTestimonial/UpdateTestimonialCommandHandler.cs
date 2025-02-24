using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Commands.UpdateTestimonial
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateTestimonialCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var testimonial = await _unitOfWork.GetReadRepository<Testimonial>().GetAsync(x=> x.Id == request.Id);

            var map = _customMapper.Map<Testimonial, UpdateTestimonialCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<Testimonial>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();
        }
    }
}
