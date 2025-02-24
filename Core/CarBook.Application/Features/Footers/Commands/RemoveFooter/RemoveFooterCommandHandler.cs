using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Commands.RemoveFooter
{
    public class RemoveFooterCommandHandler : IRequestHandler<RemoveFooterCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveFooterCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveFooterCommandRequest request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetWriteRepository<Footer>().HardDeleteByIdAsync(request.Id);

            await _unitOfWork.SaveAsync();
        }
    }
}
