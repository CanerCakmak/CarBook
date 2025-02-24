using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Contacts.Queries.GetAllContacts
{
    public class GetAllContactsQueryRequest : IRequest<IList<GetAllContactsQueryResponse>>
    {
    }
}
