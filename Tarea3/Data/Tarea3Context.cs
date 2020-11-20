using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class Tarea3Context : DbContext
    {
        public Tarea3Context (DbContextOptions<Tarea3Context> options)
            : base(options)
        {
        }

        public DbSet<Tarea3.Models.Empleado> Empleado { get; set; }
    }
}
