using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Banners.Queries.GetBannerById
{
    public class GetBannerByIdQueryRequest :IRequest<GetBannerByIdQueryResponse>
    {
        public GetBannerByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
