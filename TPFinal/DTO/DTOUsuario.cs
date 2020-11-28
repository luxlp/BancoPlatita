using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.DTO
{
    public class DTOUsuario
    {

        private string iNombre;
        private string iCategoria;

       

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public string Categoria
        {
            get { return this.iCategoria; }
            set { this.iCategoria=value; }
        }

        public DTOUsuario(string pNombre, string pCategoria)
        {
            this.iNombre = pNombre;
            this.iCategoria = pCategoria;
        }

        public DTOUsuario()
        {           
        }

    }
}
