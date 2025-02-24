using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Queries.GetSocialMediaById
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQueryRequest, GetSocialMediaByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetSocialMediaByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetSocialMediaByIdQueryResponse> Handle(GetSocialMediaByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var socialmedia = await _unitOfWork.GetReadRepository<SocialMedia>().GetAsync(x=>x.Id == request.Id);

            var map = _customMapper.Map<GetSocialMediaByIdQueryResponse,SocialMedia>(socialmedia);

            return map;
        }
    }
}
