﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Brands.Commands.UpdateBrand
{
    public class UpdateBrandCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
