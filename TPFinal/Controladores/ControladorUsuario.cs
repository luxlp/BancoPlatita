using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL;
using TPFinal.Clases;

namespace TPFinal.Controladores
{
    class ControladorUsuario
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorUsuario(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public void RegistrarUsuario(string pNombre, string pCategoria)
        {
            if (iUdT.RepositorioUsuario.UsuarioYaExiste(pNombre,pCategoria) == false)
            {
                Usuario iUsuario = new Usuario(pNombre, pCategoria);
                iUdT.RepositorioUsuario.Agregar(iUsuario);
                iUdT.Guardar();
            }           
        }

        public void RegistrarUsuario(Usuario pUsuario)
        {
            if(iUdT.RepositorioUsuario.UsuarioYaExiste(pUsuario.Nombre,pUsuario.Categoria)==false)
            {
                iUdT.RepositorioUsuario.Agregar(pUsuario);
                iUdT.Guardar();
            }       
        }

        public bool UsuarioYaExiste(Usuario pUsuario)
        {
            return iUdT.RepositorioUsuario.UsuarioYaExiste(pUsuario.Nombre, pUsuario.Categoria);
        }

        public void BajaUsuario(Usuario pUsuario)
        {
            iUdT.RepositorioUsuario.Eliminar(pUsuario);
            iUdT.Guardar();
        }

        public Usuario ObtenerUsuario(int pId)
        {
            return iUdT.RepositorioUsuario.Obtener(pId);
        }

        public Usuario ObtenerUsuario(string pNombre, string pCategoria)
        {
            return iUdT.RepositorioUsuario.ObtenerPorNombreyCat(pNombre, pCategoria);
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iUdT.RepositorioUsuario.ObtenerTodos();
        }
    }
}
