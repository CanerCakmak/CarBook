using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Commands.UpdateContact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.GetReadRepository<Contact>().GetAsync(x => x.Id == request.Id);

            var map = _customMapper.Map<Contact, UpdateContactCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<Contact>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();
        }
    }
}
