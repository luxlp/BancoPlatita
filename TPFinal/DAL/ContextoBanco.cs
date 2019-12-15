using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TPFinal.Clases;

namespace TPFinal.DAL
{
    public class ContextoBanco : DbContext
    {
        public DbSet<Operacion> Operaciones { get; set; }
    }
}
