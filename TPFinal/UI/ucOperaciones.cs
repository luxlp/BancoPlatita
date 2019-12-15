using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class ucOperaciones : UserControl
    {
        private static ucOperaciones _instancia;

        public String Dni { get; set; }

        public Panel Contenedor { get; set; }

        public ucOperaciones()
        {
            InitializeComponent();
        }

        public static ucOperaciones Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ucOperaciones();
                }
                return _instancia;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonBlanquearPin_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarTarjetas(Contenedor);
        }

        private void buttonConsultarSaldo_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarSaldo(Contenedor);
        }

        private void buttonUltimosMovimientos_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarMovimientos(Contenedor);
        }
    }
}
