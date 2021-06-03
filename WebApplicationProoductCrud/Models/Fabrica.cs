using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProoductCrud.Models
{
    public class Fabrica
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NomeFabri { get; set; }
      
        public Fabrica()
        {
            Id = Guid.NewGuid();
        }
    }
}
