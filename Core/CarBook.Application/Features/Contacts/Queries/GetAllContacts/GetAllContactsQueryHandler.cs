using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Queries.GetAllContacts
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQueryRequest, IList<GetAllContactsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllContactsQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllContactsQueryResponse>> Handle(GetAllContactsQueryRequest request, CancellationToken cancellationToken)
        {
            var contacts = await _unitOfWork.GetReadRepository<Contact>().GetAllAsync(x => !x.IsDeleted);

            var map = _customMapper.Map<GetAllContactsQueryResponse , Contact>(contacts);

            return map;
        }
    }
}
