using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Angl.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    // название 
        public string Company { get; set; } // производитель
        [Column(TypeName = "decimal(15, 2)")]
        public decimal Price { get; set; }  // цена
    }
}
