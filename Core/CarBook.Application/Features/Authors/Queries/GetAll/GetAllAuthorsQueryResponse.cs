using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Authors.Queries.GetAllAuthors
{
    public class GetAllAuthorsQueryResponse
    {
        public int Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
