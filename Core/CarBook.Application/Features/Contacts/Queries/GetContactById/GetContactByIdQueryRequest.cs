using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Queries.GetContactById
{
    public class GetContactByIdQueryRequest : IRequest<GetContactByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetContactByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
