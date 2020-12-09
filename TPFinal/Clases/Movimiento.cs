using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Movimiento
    {
        public string fecha { get; set; }
        public float cantidad { get; set; }

        public Movimiento(string pFecha, float pCantidad)
        {
            this.fecha = pFecha;
            this.cantidad = pCantidad;

        }
    }
}
