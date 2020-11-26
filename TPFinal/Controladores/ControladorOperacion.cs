using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL;
using TPFinal.Clases;

namespace TPFinal.Controladores
{
    class ControladorOperacion
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorOperacion(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public void RegistrarOperacion(string pTipoOperacion, string pTiempoInsumido, Usuario pUsuario)
        {
            iUdT.RepositorioOperacion.Agregar(pTipoOperacion, pTiempoInsumido, pUsuario);
            iUdT.Guardar();
        }        
    }
}
