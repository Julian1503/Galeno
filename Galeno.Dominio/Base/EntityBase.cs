using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeno.Infraestructura.Repositorio
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int EstaEliminado { get; set; }
    }
}
