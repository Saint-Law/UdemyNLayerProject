﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Api.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} field is required")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "{0} field must be a value greater than 1")]
        public int Stock { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "{0} field must be a value greater than 1")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
