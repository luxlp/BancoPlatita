using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.Interfaces;
using TPFinal.DTO;
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

        public DTOUsuario ObtenerPorNombreyCat(string pNombre, string pCategoria)
        {
            Usuario Resultado;
            Resultado = iContext.Usuario.FirstOrDefault(n => n.Nombre == pNombre && n.Categoria == pCategoria);
            return ConvertirADTO(Resultado);
        }

        public void Agregar(string pNombre,string  pCategoria)
        {
            Usuario iUsuario = new Usuario(pNombre, pCategoria);
            this.iContext.Set<Usuario>().Add(iUsuario);
        }

        public Usuario ConvertirAEntidad(DTOUsuario pDTOUsuario)
        {
            Usuario iUsuario = new Usuario(pDTOUsuario.Nombre, pDTOUsuario.Categoria);
            return iUsuario;
        }

        public DTOUsuario ConvertirADTO(Usuario pUsuario)
        {
            DTOUsuario iDTOUsuario = new DTOUsuario(pUsuario.Nombre, pUsuario.Categoria);
            return iDTOUsuario;
        }
    }
}
