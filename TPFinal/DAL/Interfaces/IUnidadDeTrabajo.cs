using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.DAL.Interfaces
{
    interface IUnidadDeTrabajo
    {
        IRepositorioOperacion RepositorioOperacion { get; }

        void Guardar();
    }
}
