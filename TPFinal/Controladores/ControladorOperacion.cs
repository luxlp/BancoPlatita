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

        public void RegistrarOperacion()
        {
            Operacion iOperacion = new Operacion();
            iUdT.RepositorioOperacion.Agregar(iOperacion);
            iUdT.Guardar();
        }        

        public void BajaOperacion(Operacion pOperacion)
        {
            iUdT.RepositorioOperacion.Eliminar(pOperacion);
            iUdT.Guardar();
        }

        public Operacion ObtenerOperacion(int pId)
        {
            return iUdT.RepositorioOperacion.Obtener(pId);
        }

        public IList<Operacion> ObtenerTodos()
        {
            return iUdT.RepositorioOperacion.ObtenerTodos();
        }
    }
}
