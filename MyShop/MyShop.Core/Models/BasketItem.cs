﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class BasketItem : BaseEntity
    {
        public string BasketdId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
