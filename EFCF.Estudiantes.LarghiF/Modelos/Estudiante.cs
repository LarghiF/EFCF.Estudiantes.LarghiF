using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Estudiantes.LarghiF.Modelos
{
    [Table("EFCFEstudiantes")]
    public class Estudiante
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Apellido { get; set; }
        public decimal Promedio { get; set; }

        
    }
}
