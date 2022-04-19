using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Estudiantes.LarghiF.Modelos
{
    public class EstudianteDbContext:DbContext
    {
        public EstudianteDbContext() : base("MiConexion")
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
