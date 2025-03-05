using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Queries.GetBlogWithAuthorById
{
    public class GetBlogWithAuthorByIdQueryRequest : IRequest<GetBlogWithAuthorByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetBlogWithAuthorByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
