using CarBook.Application.DTOs.CarDtos;
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

namespace CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar
{
    public class GetAllCarPricesWithCarQueryHandler : IRequestHandler<GetAllCarPricesWithCarQueryRequest, IList<GetAllCarPricesWithCarQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllCarPricesWithCarQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllCarPricesWithCarQueryResponse>> Handle(GetAllCarPricesWithCarQueryRequest request, CancellationToken cancellationToken)
        {
            var prices = await _unitOfWork.GetReadRepository<CarPricing>().GetAllAsync(x=> !x.IsDeleted , include: x=> x.Include(p=>p.Pricing).Include(p => p.Car).ThenInclude(c=>c.Brand));

            var priceMap = _customMapper.Map<PricingDto, Pricing>(new Pricing());

            var carMap = _customMapper.Map<GetAllCarPricesCarDtoResponse , Car>(new Car());

            var map = _customMapper.Map<GetAllCarPricesWithCarQueryResponse, CarPricing>(prices);

            return map;

        }
    }
}
