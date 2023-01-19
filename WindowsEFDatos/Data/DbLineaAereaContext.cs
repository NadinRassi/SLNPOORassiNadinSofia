using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Entities;

namespace WindowsEFDatos.Data
{
    public class DbLineaAereaContext : DbContext
    {
        public DbLineaAereaContext() : base("KeyDB") { }

        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaAerea> LineasAereas { get; set; }
    }
}
