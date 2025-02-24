using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQueryRequest, IList<GetAllServicesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllServicesQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllServicesQueryResponse>> Handle(GetAllServicesQueryRequest request, CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.GetReadRepository<Service>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllServicesQueryResponse , Service>(services);

            return map;
        }
    }
}
