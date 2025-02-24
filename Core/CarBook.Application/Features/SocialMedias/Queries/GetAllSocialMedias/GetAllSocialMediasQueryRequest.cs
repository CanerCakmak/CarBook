using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Queries.GetAllSocialMedias
{
    public class GetAllSocialMediasQueryRequest : IRequest<IList<GetAllSocialMediasQueryResponse>>
    {
    }
}
