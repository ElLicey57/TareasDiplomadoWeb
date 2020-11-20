using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class Inicilizador
    {
        public static void Inicializar(Tarea3Context context)
        {
            context.Database.EnsureCreated();

            if (context.Empleado.Any())
            {
                return;
            }
            var empleados = new Empleado[]
            {
                new Empleado { Nombre = "Juan Perez", Sueldo = 15000, FechaIngreso = DateTime.Now },
                new Empleado { Nombre = "Maria Rodriguez", Sueldo = 16000, FechaIngreso = DateTime.Now }
            };

            foreach (Empleado c in empleados)
            {
                context.Empleado.Add(c);
            }
            context.SaveChanges();
        }
    }
}