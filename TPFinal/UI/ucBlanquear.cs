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
    public partial class ucBlanquear : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private static ucBlanquear _instancia;
        private List<Product> _tarjetas;

        public ucBlanquear()
        {
            log.Debug("Inicializando ucBlanquear...");
            InitializeComponent();
            log.Debug("ucBlanquear inicializado.");
        }

        public static ucBlanquear Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ucBlanquear();
                }
                return _instancia;
            }
        }

        public List<Product> Tarjetas
        {
            set
            {
                _tarjetas = value;
                CargarTarjetas();
            }
        }

        private void CargarTarjetas()
        {
            log.Debug("Cargando tarjetas...");
            foreach (Product t in _tarjetas)
            {
                ucTarjeta tarjeta = new ucTarjeta();
                tarjeta.Tarjeta = t;
                tarjeta.Dock = DockStyle.Top;
                tarjeta.BringToFront();
                tableLayoutPanel2.Controls.Add(tarjeta);
            }
            log.Info("Tarjetas cargadas.");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            log.Debug("Saliendo de aplicación...");
            Application.Restart();
        }
    }
}
