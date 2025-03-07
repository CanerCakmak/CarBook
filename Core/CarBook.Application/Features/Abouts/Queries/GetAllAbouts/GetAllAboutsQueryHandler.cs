using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Queries.GetAllAbouts
{
    public class GetAllAboutsQueryHandler : IRequestHandler<GetAllAboutsQueryRequest, IList<GetAllAboutsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICustomMapper customMapper;

        public GetAllAboutsQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            this.unitOfWork = unitOfWork;
            this.customMapper = customMapper;
        }
        public async Task<IList<GetAllAboutsQueryResponse>> Handle(GetAllAboutsQueryRequest request, CancellationToken cancellationToken)
        {
            var abouts = await unitOfWork.GetReadRepository<About>().GetAllAsync(x=> !x.IsDeleted);

            var map = customMapper.Map<GetAllAboutsQueryResponse,About>(abouts);

            return map;

        }
    }
}
