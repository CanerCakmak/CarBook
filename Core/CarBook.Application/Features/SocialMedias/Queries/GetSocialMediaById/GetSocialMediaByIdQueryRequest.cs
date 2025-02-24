using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Queries.GetSocialMediaById
{
    public class GetSocialMediaByIdQueryRequest : IRequest<GetSocialMediaByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
