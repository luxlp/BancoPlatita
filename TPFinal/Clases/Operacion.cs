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

        public int OperacionId { get; set; }

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

        public Operacion(string pTipoOperacion, string pTiempoInsumido, Usuario pUsuario)
        {
            this.iTipoOperacion = pTipoOperacion;
            this.iTiempoInsumido = pTiempoInsumido;
            this.Usuario = pUsuario;
        }

        public Operacion()
        {
        }
    }
}
