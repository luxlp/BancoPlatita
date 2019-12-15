using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.DAL.Interfaces
{
    interface IRepositorioGeneral<TEntity> where TEntity : class
    {
        void Agregar(TEntity pEntity);
        void Eliminar(TEntity pEntity);
        void Modificar(TEntity pEtity);
        TEntity Obtener(int pId);
        IList<TEntity> ObtenerTodos();
    }
}
