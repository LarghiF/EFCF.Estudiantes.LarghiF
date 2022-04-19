using EFCF.Estudiantes.LarghiF.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Estudiantes.LarghiF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menu principal.");
            Console.WriteLine("Opciones:\nL = Listar estudiantes\nA = Agregar estudiantes\n" +
                "B = Borrar estudiante\nE = Editar estudiante");
            var r = Console.ReadLine();
            if (r.ToLower() == "a")
            {
                Console.Clear();
                Console.WriteLine("Completar los datos requeridos:");
                AgregarEstudiante();
            }
            else if (r.ToLower() == "b")
            {
                Console.Clear();
                BorrarEstudiante();

            }
            else if (r.ToLower() == "l")
            {
                Console.Clear();
                ListaEstudiantes();
            }
            else if (r.ToLower() == "e")
            {
                Console.Clear();
                EditarEstudiante();
            }
            else
            {
                Console.WriteLine("Error!");
            }

            Console.ReadLine();
        }

        private static void ListaEstudiantes()
        {
            using (var context = new EstudianteDbContext())
            {
                var lista = context.Estudiantes.ToList();
                foreach (var e in lista)
                {
                    Console.WriteLine($"{e.Nombres}, {e.Apellido} Promedio: {e.Promedio}");
                }
                Console.WriteLine($"\nCantidad de registros: {context.Estudiantes.Count()}");
            }
        }

        private static void AgregarEstudiante()
        {
            using (var context = new EstudianteDbContext())
            {
                //No se como hacerlo para que quede bien
                Console.WriteLine("Nombre\nApellido\nPromedio");
                var e = new Estudiante()
                {
                    Nombres = Console.ReadLine(),
                    Apellido = Console.ReadLine(),
                    Promedio = decimal.Parse(Console.ReadLine())
                };
                context.Estudiantes.Add(e);
                context.SaveChanges();
                Console.WriteLine("Registro Agregado");
            }
        }
        private static void BorrarEstudiante()
        {
            using (var context = new EstudianteDbContext())
            {
                Console.WriteLine("Ingrese el ID del estudiante");
                var eID = int.Parse(Console.ReadLine());
                var estudiante = context.Estudiantes.SingleOrDefault(e => e.ID == eID);
                if (estudiante != null)
                {
                    context.Estudiantes.Remove(estudiante);
                    context.SaveChanges();
                    Console.WriteLine("Registro Borrado");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
        private static void EditarEstudiante()
        {
            using (var context = new EstudianteDbContext())
            {
                Console.Write("ID del estudiante a modificar:");
                var id = int.Parse(Console.ReadLine());
                var estudiante = context.Estudiantes.SingleOrDefault(e => e.ID == id);
                Console.WriteLine("Nombre\nApellido\nPromedio");
                if (estudiante != null)
                {
                    estudiante.Nombres = Console.ReadLine();
                    estudiante.Apellido = Console.ReadLine();
                    estudiante.Promedio = decimal.Parse(Console.ReadLine());

                    context.SaveChanges();
                    Console.WriteLine("Registro editado");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
