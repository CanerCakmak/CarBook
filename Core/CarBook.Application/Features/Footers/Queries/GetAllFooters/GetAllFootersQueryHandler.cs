using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Queries.GetAllFooters
{
    public class GetAllFootersQueryHandler : IRequestHandler<GetAllFootersQueryRequest, IList<GetAllFootersQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllFootersQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllFootersQueryResponse>> Handle(GetAllFootersQueryRequest request, CancellationToken cancellationToken)
        {
            var footers = await _unitOfWork.GetReadRepository<Footer>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllFootersQueryResponse , Footer>(footers);

            return map;
        }
    }
}
