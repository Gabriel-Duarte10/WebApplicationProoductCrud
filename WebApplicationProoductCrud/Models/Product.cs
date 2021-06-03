using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProoductCrud.Models
{
    public class Product
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NomeProd { get; set; }
        [Required]
        public string NomeFabri { get; set; }
        [Required]
        public string CategoryProd { get; set; }
        [Required]
        public int QtdProd { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double ValueProd { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
