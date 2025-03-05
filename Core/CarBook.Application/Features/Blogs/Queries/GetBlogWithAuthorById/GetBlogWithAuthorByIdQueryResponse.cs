using CarBook.Application.DTOs.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Queries.GetBlogWithAuthorById
{
    public class GetBlogWithAuthorByIdQueryResponse
    {
        public string Title { get; set; }
        public string CoverImagePath { get; set; }
        public AuthorDto Author { get; set; }
    }
}
