using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Queries.GetAllSocialMedias
{
    public class GetAllSocialMediasQueryHandler : IRequestHandler<GetAllSocialMediasQueryRequest, IList<GetAllSocialMediasQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllSocialMediasQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllSocialMediasQueryResponse>> Handle(GetAllSocialMediasQueryRequest request, CancellationToken cancellationToken)
        {
            var socialmedias = await _unitOfWork.GetReadRepository<SocialMedia>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllSocialMediasQueryResponse,SocialMedia>(socialmedias);

            return map;
        }
    }
}
