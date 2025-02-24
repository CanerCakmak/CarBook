using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Footers.Queries.GetFooterById
{
    public class GetFooterByIdQueryResponse
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
