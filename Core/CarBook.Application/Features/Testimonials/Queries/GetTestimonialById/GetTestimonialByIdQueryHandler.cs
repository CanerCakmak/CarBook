using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Queries.GetTestimonialById
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQueryRequest, GetTestimonialByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetTestimonialByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetTestimonialByIdQueryResponse> Handle(GetTestimonialByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var testimonial = await _unitOfWork.GetReadRepository<Testimonial>().GetAsync(x=> x.Id == request.Id);

            var map = _customMapper.Map<GetTestimonialByIdQueryResponse , Testimonial>(testimonial);

            return map;
        }
    }
}
