﻿using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class SocialMedia : BaseEntity
    {
        public SocialMedia()
        {
            
        }
        public SocialMedia(string name, string url, string iconpath)
        {
            Name = name;
            Url = url;
            IconPath = iconpath;
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconPath { get; set; }

    }
}
