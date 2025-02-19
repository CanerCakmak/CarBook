using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Queries.GetAboutById
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQueryRequest, GetAboutByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAboutByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetAboutByIdQueryResponse> Handle(GetAboutByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var about = await _unitOfWork.GetReadRepository<About>().GetAsync(x => x.Id == request.Id);

            var map = _customMapper.Map<GetAboutByIdQueryResponse>(about);

            return map;
        }
    }
}
