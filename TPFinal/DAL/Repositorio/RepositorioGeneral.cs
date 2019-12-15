using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.Interfaces;
using System.Data.Entity;

namespace TPFinal.DAL.Repositorio
{
    abstract class RepositorioGeneral<TEntity, TDbContext> : IRepositorioGeneral<TEntity>
        where TEntity : class
        where TDbContext : DbContext
    {
        protected readonly TDbContext iContext;
        public RepositorioGeneral(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iContext = pContext;
        }

        public void Agregar(TEntity pEntity)
        {
            this.iContext.Set<TEntity>().Add(pEntity);
        }

        public void Eliminar(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iContext.Set<TEntity>().Remove(pEntity);
        }

        public void Modificar(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new NullReferenceException(nameof(pEntity));
            }
            this.iContext.Set<TEntity>().Attach(pEntity);
            var entry = iContext.Entry(pEntity);
            entry.State = EntityState.Modified;
        }

        public TEntity Obtener(int pId)
        {
            return this.iContext.Set<TEntity>().Find(pId);
        }

        public IList<TEntity> ObtenerTodos()
        {
            return this.iContext.Set<TEntity>().ToList();
        }
    }
}
