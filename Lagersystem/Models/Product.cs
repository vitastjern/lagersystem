﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lagersystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PictureURL { get; set; }
    }
}