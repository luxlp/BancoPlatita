using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.Interfaces;
using TPFinal.Clases;

namespace TPFinal.DAL.Repositorio
{
    class RepositorioUsuario : RepositorioGeneral<Usuario, ContextoBanco>, IRepositorioUsuario
    {
        public RepositorioUsuario(ContextoBanco pContext) : base(pContext)
        {
        }
    }
}
