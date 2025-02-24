using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Banners.Commands.RemoveBanner
{
    public class RemoveBannerCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
