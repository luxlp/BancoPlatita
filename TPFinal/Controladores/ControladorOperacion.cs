using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL;
using TPFinal.Clases;
using TPFinal.DTO;

namespace TPFinal.Controladores
{
    class ControladorOperacion
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorOperacion(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public void RegistrarOperacion(string pTipoOperacion, string pTiempoInsumido, DTOUsuario pUsuario)
        {
            Usuario iUsuario = iUdT.RepositorioUsuario.ConvertirAEntidad(pUsuario);
            iUdT.RepositorioOperacion.Agregar(pTipoOperacion, pTiempoInsumido, iUsuario);
            iUdT.Guardar();
        }        
    }
}
