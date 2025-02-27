using CarBook.Application.DTOs.BrandDtos;
using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Cars.Queries.GetCarsWithBrandByCount
{
    public class GetCarsWithBrandByCountQueryHandler : IRequestHandler<GetCarsWithBrandByCountQueryRequest, IList<GetCarsWithBrandByCountQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetCarsWithBrandByCountQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetCarsWithBrandByCountQueryResponse>> Handle(GetCarsWithBrandByCountQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = await _unitOfWork.GetReadRepository<Car>()
                .GetAllByPagingAsync(
                    predicate: x => !x.IsDeleted,
                    include: x => x.Include(c => c.Brand),
                    orderBy: x => x.OrderByDescending(c => c.CreatedAt),
                    currentPage: 1,
                    pageSize: request.Count
                );

            var brand = _customMapper.Map<BrandDto, Brand>(new Brand());

            var map = _customMapper.Map<GetCarsWithBrandByCountQueryResponse , Car>(cars);

            return map;
        }
    }
}
