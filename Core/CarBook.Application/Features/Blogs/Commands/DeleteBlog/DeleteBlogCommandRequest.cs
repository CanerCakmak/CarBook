using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteBlogCommandRequest(int id)
        {
            Id = id;
        }
    }
}
