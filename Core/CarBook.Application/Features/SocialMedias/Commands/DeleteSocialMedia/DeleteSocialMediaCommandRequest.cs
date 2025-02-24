using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.DeleteSocialMedia
{
    public class DeleteSocialMediaCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteSocialMediaCommandRequest(int id)
        {
            Id = id;
        }
    }
}
