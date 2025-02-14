﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Common
{
    public class BaseEntity
    {
        public Guid ID{ get; set; }
        public bool Status { get; set; }


        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
