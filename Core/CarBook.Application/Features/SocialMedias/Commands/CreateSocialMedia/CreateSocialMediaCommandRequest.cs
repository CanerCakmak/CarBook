﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.SocialMedias.Commands.CreateSocialMedia
{
    public class CreateSocialMediaCommandRequest : IRequest
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconPath { get; set; }
    }
}
