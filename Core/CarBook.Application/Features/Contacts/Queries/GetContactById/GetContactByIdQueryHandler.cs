using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Queries.GetContactById
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQueryRequest, GetContactByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;
        public GetContactByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        async Task<GetContactByIdQueryResponse> IRequestHandler<GetContactByIdQueryRequest, GetContactByIdQueryResponse>.Handle(GetContactByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.GetReadRepository<Contact>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = _customMapper.Map<GetContactByIdQueryResponse>(contact);

            return map;
        }
    }
}
