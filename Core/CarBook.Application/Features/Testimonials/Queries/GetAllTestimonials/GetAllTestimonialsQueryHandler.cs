using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Testimonials.Queries.GetAllTestimonials
{
    public class GetAllTestimonialsQueryHandler : IRequestHandler<GetAllTestimonialsQueryRequest, IList<GetAllTestimonialsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllTestimonialsQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllTestimonialsQueryResponse>> Handle(GetAllTestimonialsQueryRequest request, CancellationToken cancellationToken)
        {
            var testimonials = await _unitOfWork.GetReadRepository<Testimonial>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllTestimonialsQueryResponse, Testimonial>(testimonials);

            return map;
        }
    }
}
