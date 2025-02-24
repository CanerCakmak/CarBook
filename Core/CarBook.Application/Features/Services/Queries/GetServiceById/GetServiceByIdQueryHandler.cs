using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Queries.GetServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQueryRequest, GetServiceByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetServiceByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetServiceByIdQueryResponse> Handle(GetServiceByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var service = await _unitOfWork.GetReadRepository<Service>().GetAsync(x=> x.Id == request.Id);

            var map = _customMapper.Map<GetServiceByIdQueryResponse,Service>(service); 

            return map;
        }
    }
}
