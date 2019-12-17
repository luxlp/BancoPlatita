using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.Clases
{
    public class Operacion
    {
        private string iTipoOperacion;
        private string iTiempoInsumido;

        public string TipoOperacion
        {
            get { return this.iTipoOperacion; }
            set { this.iTipoOperacion = value; }
        }
        public string TiempoInsumido
        {
            get { return this.iTiempoInsumido; }
            set { this.iTiempoInsumido = value; }
        }

        public virtual Usuario Usuario { get; set; }
    }
}
