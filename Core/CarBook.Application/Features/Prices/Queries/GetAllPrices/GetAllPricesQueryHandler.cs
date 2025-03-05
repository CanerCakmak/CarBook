using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Prices.Queries.GetAllPrices
{
    public class GetAllPricesQueryHandler : IRequestHandler<GetAllPricesQueryRequest, IList<GetAllPricesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllPricesQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllPricesQueryResponse>> Handle(GetAllPricesQueryRequest request, CancellationToken cancellationToken)
        {
            var prices =  await _unitOfWork.GetReadRepository<Pricing>().GetAllAsync(x=> !x.IsDeleted);

            var response = _customMapper.Map<GetAllPricesQueryResponse , Pricing>(prices);

            return response;
        }
    }
}
