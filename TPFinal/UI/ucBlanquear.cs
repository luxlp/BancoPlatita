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
        private static ucBlanquear _instancia;
        private List<Product> _tarjetas;

        public ucBlanquear()
        {
            InitializeComponent();
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
            foreach (Product t in _tarjetas)
            {
                ucTarjeta tarjeta = new ucTarjeta();
                tarjeta.Tarjeta = t;
                tarjeta.Dock = DockStyle.Top;
                tarjeta.BringToFront();
                tableLayoutPanel2.Controls.Add(tarjeta);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
