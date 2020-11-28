using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.DTO
{
    public class DTOOperacion
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

        public int iUsuarioId { get; set; }

        public DTOOperacion(string pTipoOperacion, string pTiempoInsumido, int pUsuarioId)
        {
            this.iTipoOperacion = pTipoOperacion;
            this.iTiempoInsumido = pTiempoInsumido;
            this.iUsuarioId = pUsuarioId;
        }

        public DTOOperacion()
        {
        }
    }
}
