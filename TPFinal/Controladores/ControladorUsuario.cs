using System.Collections.Generic;
using TPFinal.DAL;


namespace TPFinal.Controladores
{
    class ControladorUsuario
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorUsuario(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

          
      
        public Usuario ObtenerUsuario(string pNombre, string pCategoria)
        {
            
            
            if (iUdT.RepositorioUsuario.UsuarioYaExiste(pNombre, pCategoria) == false)
            {
                iUdT.RepositorioUsuario.Agregar(pNombre, pCategoria);
                iUdT.Guardar();
            }
            
            return iUdT.RepositorioUsuario.ObtenerPorNombreyCat(pNombre, pCategoria);
           
        }

    }
}
