using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
   
        public class Producto
        {
            public string numero { get; set; }
            public string nombre { get; set; }
            public string tipo { get; set; }

        public Producto(string pNumero, string pNombre, string pTipo)
        {
            this.numero = pNumero;
            this.nombre = pNombre;
            this.tipo = pTipo;
        }
    }
    
}
