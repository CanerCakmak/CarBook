using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Commands.CreateFooter
{
    public class CreateFooterCommandHandler : IRequestHandler<CreateFooterCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateFooterCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateFooterCommandRequest request, CancellationToken cancellationToken)
        {
            Footer footer = new(request.Detail, request.Address, request.PhoneNumber, request.Email);

            await _unitOfWork.GetWriteRepository<Footer>().AddAsync(footer);

            await _unitOfWork.SaveAsync();
        }
    }
}
