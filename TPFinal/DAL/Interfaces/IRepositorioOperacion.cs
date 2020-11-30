using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.Clases;
using TPFinal.DTO;

namespace TPFinal.DAL.Interfaces
{
    interface IRepositorioOperacion : IRepositorioGeneral<Operacion>
    {
        void Agregar(string pTipoOperacion, string pTiempoInsumido, Usuario pUsuario);
        void Eliminar(int pOperacionId);
    }
}
