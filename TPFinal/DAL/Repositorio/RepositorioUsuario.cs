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

        public bool UsuarioYaExiste(string pNombre, string pCategoria)
        {
            bool Resultado;
            Resultado = iContext.Usuario.Any(n => n.Nombre == pNombre && n.Categoria == pCategoria);
            return Resultado;
        }
    }
}
