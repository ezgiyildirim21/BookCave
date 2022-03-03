﻿using BookCave.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace BookCave.Domain.Entities
{
    public class Order : BaseEntity
    {
        //TODO: USER BAĞLANTISI
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
    }
}
