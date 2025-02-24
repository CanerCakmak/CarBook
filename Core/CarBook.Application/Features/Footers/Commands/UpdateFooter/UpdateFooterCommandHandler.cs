using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Commands.UpdateFooter
{
    public class UpdateFooterCommandHandler : IRequestHandler<UpdateFooterCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateFooterCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateFooterCommandRequest request, CancellationToken cancellationToken)
        {
            var footer = await _unitOfWork.GetReadRepository<Footer>().GetAsync(x=> x.Id == request.Id);

            var map = _customMapper.Map<Footer , UpdateFooterCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<Footer>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();

        }
    }
}
