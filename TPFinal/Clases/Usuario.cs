using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Usuario
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

        public Usuario(string pNombre, string pCategoria)
        {
            this.iNombre = pNombre;
            this.iCategoria = pCategoria;
        }
    }
}
