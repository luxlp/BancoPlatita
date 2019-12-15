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
    public partial class ucSaldo : UserControl
    {
        private static ucSaldo _instancia;
        private float _saldo;

        public ucSaldo()
        {
            InitializeComponent();
        }

        public static ucSaldo Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ucSaldo();
                }
                return _instancia;
            }
        }

        public float Saldo
        {
            set
            {
                this._saldo = value;
                CargarSaldo();
            }
        }

        private void CargarSaldo()
        {
            labelSaldo.Text = Convert.ToString(_saldo);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
