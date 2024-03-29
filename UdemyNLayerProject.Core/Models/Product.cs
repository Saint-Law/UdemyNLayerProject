﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyNLayerProject.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool isDeleted { get; set; }
        public string InnerBaccode { get; set; }

        public virtual Category Category { get; set; }
    }
}
