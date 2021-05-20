using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Web.DTOs
{
    public class CategoryDto 
    {
        public int Id { get; set; }

        [Required(ErrorMessage =" {0} field cant be empty")]
        public string Name { get; set; }
    }
}
