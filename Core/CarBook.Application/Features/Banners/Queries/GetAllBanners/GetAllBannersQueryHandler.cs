using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;

namespace CarBook.Application.Features.Banners.Queries.GetAllBanners
{
    public class GetAllBannersQueryHandler : IRequestHandler<GetAllBannersQueryRequest, IList<GetAllBannersQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllBannersQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllBannersQueryResponse>> Handle(GetAllBannersQueryRequest request, CancellationToken cancellationToken)
        {
            var banners = await _unitOfWork.GetReadRepository<Banner>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllBannersQueryResponse, Banner>(banners);

            return map;
        }
    }
}
