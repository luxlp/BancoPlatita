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
            Usuario iUsuario = new Usuario(pNombre,pCategoria);
            iUdT.RepositorioUsuario.Agregar(iUsuario);
            iUdT.Guardar();
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

        public IList<Usuario> ObtenerTodos()
        {
            return iUdT.RepositorioUsuario.ObtenerTodos();
        }
    }
}
