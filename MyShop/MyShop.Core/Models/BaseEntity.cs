﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class BaseEntity
    {
        public string ID { get; set; }
        public DateTimeOffset CreatedAt { get; set; } //for troubleshoot

        public BaseEntity()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }

    }
}
