using CarBook.Application.DTOs.AuthorDtos;
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

namespace CarBook.Application.Features.Blogs.Queries.GetAllBlogs
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQueryRequest, IList<GetAllBlogsWithAuthorQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetAllBlogsWithAuthorQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<IList<GetAllBlogsWithAuthorQueryResponse>> Handle(GetAllBlogsWithAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var blogs = await _unitOfWork.GetReadRepository<Blog>().GetAllAsync(x => !x.IsDeleted, include: x => x.Include(b => b.Author));

            var author = _customMapper.Map<AuthorDto, Author>(new Author());

            var map = _customMapper.Map<GetAllBlogsWithAuthorQueryResponse, Blog>(blogs);

            return map;
        }
    }
}
