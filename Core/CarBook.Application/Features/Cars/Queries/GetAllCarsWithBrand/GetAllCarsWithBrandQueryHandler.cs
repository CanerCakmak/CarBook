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

namespace CarBook.Application.Features.Cars.Queries.GetAllCarsWithBrand
{
    public class GetAllCarsWithBrandQueryHandler : IRequestHandler<GetAllCarsWithBrandQueryRequest, IList<GetAllCarsWithBrandQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllCarsWithBrandQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }
        public async Task<IList<GetAllCarsWithBrandQueryResponse>> Handle(GetAllCarsWithBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Car>().GetAllAsync(x=> !x.IsDeleted ,include: x=> x.Include(c=>c.Brand));

            var brand = _customMapper.Map<BrandDto, Brand>(new Brand());

            var map = _customMapper.Map<GetAllCarsWithBrandQueryResponse,Car>(car);

            return map;
        }
    }
}
