using CarBook.Application.DTOs.BrandDtos;
using CarBook.Application.DTOs.CarPricingDto;
using CarBook.Application.DTOs.PricingDtos;
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

namespace CarBook.Application.Features.Cars.Queries.GetAllCarsWithPriceAndBrand
{
    public class GetAllCarsWithPriceAndBrandQueryHandler : IRequestHandler<GetAllCarsWithPriceAndBrandQueryRequest, IList<GetAllCarsWithPriceAndBrandQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllCarsWithPriceAndBrandQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllCarsWithPriceAndBrandQueryResponse>> Handle(GetAllCarsWithPriceAndBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = await _unitOfWork.GetReadRepository<Car>()
                .GetAllAsync
                (x => !x.IsDeleted,
                include: x => x.Include(c => c.Brand).Include(c => c.CarPricings).ThenInclude(cp => cp.Pricing)
                );

            var brandmap = _customMapper.Map<BrandDto, Brand>(new Brand());
            var cpmap = _customMapper.Map<CarPricingDto, CarPricing>(new CarPricing());
            var pricingmap = _customMapper.Map<PricingDto, Pricing>(new Pricing());

            var response = _customMapper.Map<GetAllCarsWithPriceAndBrandQueryResponse, Car>(cars);

            return response;
        }
    }
}
