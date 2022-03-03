﻿using BookCave.Domain.Abstracts;
using BookCave.Domain.Entities.Common;

namespace BookCave.Domain.Entities
{
    public class CategoryDetail : IEntity
    {
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public string ISBN { get; set; }
        public Book Book { get; set; }
    }
}
