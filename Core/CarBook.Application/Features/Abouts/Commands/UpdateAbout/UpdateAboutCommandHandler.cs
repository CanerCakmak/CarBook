using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.MainPage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Abouts.Commands.UpdateAbout
{
    internal class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateAboutCommandHandler(
            IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var about = await _unitOfWork.GetReadRepository<About>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = _customMapper.Map<About,UpdateAboutCommandRequest>(request);

            await _unitOfWork.GetWriteRepository<About>().UpdateAsync(map);

            await _unitOfWork.SaveAsync();

        }
    }
}
