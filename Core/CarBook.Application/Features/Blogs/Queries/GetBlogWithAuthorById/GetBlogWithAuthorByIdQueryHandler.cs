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

namespace CarBook.Application.Features.Blogs.Queries.GetBlogWithAuthorById
{
    public class GetBlogWithAuthorByIdQueryHandler : IRequestHandler<GetBlogWithAuthorByIdQueryRequest, GetBlogWithAuthorByIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;

        public GetBlogWithAuthorByIdQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }

        public async Task<GetBlogWithAuthorByIdQueryResponse> Handle(GetBlogWithAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var blog = await _unitOfWork.GetReadRepository<Blog>().GetAsync(x => !x.IsDeleted, include: x => x.Include(b => b.Author));

            var author = _customMapper.Map<AuthorDto, Author>(new Author());

            var map = _customMapper.Map<GetBlogWithAuthorByIdQueryResponse, Blog>(blog);

            return map;
        }
    }
}
