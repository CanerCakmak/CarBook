using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public UpdateAuthorCommandHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var author = await _unitOfWork.GetReadRepository<Author>().GetAsync(x=> x.Id == request.Id);

            

            if (author != null)
            {
                var map = _customMapper.Map<Author, UpdateAuthorCommandRequest>(request);

                await _unitOfWork.GetWriteRepository<Author>().UpdateAsync(map);
                await _unitOfWork.SaveAsync();
            }

        }
    }
}
