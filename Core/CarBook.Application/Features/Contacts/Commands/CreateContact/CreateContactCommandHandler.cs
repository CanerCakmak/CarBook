using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Commands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Contact contact = new(request.Name, request.Email, request.Subject, request.Message);

            await _unitOfWork.GetWriteRepository<Contact>().AddAsync(contact);

            await _unitOfWork.SaveAsync();
        }
    }
}
