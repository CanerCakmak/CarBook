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

namespace CarBook.Application.Features.Cars.Queries.GetCarById
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQueryRequest, GetCarByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetCarByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetCarByIdQueryResponse> Handle(GetCarByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Car>().GetAsync(x=>x.Id == request.Id);

            var map = _customMapper.Map<GetCarByIdQueryResponse, Car>(car);

            return map;
        }
    }
}
