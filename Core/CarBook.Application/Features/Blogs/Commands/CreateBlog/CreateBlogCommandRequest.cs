using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandRequest : IRequest
    {
        public string Title { get; set; }
        public string CoverImagePath { get; set; }


        public int AuthorId { get; set; }

        public IList<int> CategoryIds { get; set; }
    }
}
