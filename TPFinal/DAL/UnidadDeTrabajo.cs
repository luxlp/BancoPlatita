using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.DAL.Interfaces;
using TPFinal.DAL.Repositorio;

namespace TPFinal.DAL
{
    class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        //Definicion de la clase contexto
        private readonly ContextoBanco iDbContext;
        //Declaracion de atributo para usar en el patron singleton
        private static volatile UnidadDeTrabajo cInstancia = null;
        private static readonly object cPadlock = new object();

        private UnidadDeTrabajo()
        {
            this.iDbContext = new ContextoBanco();
            //Inicializar los repositorios
            this.RepositorioOperacion = new RepositorioOperacion(iDbContext);
            this.RepositorioUsuario = new RepositorioUsuario(iDbContext);
        }

        //Implementacion de las interfaces en la unidad de trabajo
        public IRepositorioOperacion RepositorioOperacion { get; private set; }
        public IRepositorioUsuario RepositorioUsuario { get; private set; }
        /// <summary>
        /// Patron singleton para usar el mismo contexto en todo el sistema
        /// </summary>
        public static UnidadDeTrabajo Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    lock (cPadlock)
                    {
                        if (cInstancia == null)
                        {
                            cInstancia = new UnidadDeTrabajo();
                        }
                    }
                }
                return cInstancia;
            }
        }

        /// <summary>
        /// Libera memoria
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
        /// <summary>
        /// Guarda en la base de datos 
        /// </summary>
        public void Guardar()
        {
            this.iDbContext.SaveChanges();
        }
    }
}
