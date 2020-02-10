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
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private static ucOperaciones _instancia;

        public String Dni { get; set; }

        public Panel Contenedor { get; set; }

        public ucOperaciones()
        {
            log.Debug("Inicializando ucOperaciones...");
            InitializeComponent();
            log.Debug("ucOperaciones inicializado.");
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
            log.Debug("Saliendo de aplicación...");
            Application.Restart();
        }

        private void buttonBlanquearPin_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarTarjetas(Contenedor);
            log.Debug("Mostrando tarjetas...");
        }

        private void buttonConsultarSaldo_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarSaldo(Contenedor);
            log.Debug("Mostrando saldo...");
        }

        private void buttonUltimosMovimientos_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(Contenedor);
            Ayudante.CargarMovimientos(Contenedor);
            log.Debug("Mostrando movimientos...");
        }
    }
}
