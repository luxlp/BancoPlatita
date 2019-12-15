using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.Interfaces;
using TPFinal.Clases;

namespace TPFinal.DAL.Repositorio
{
    class RepositorioOperacion : RepositorioGeneral<Operacion, ContextoBanco>, IRepositorioOperacion
    {
        public RepositorioOperacion(ContextoBanco pContext) : base(pContext)
        {
        }
    }
}
