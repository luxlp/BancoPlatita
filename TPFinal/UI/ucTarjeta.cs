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
    public partial class ucTarjeta : UserControl
    {
        private Product _tarjeta;

        public ucTarjeta()
        {
            InitializeComponent();
        }

        public Product Tarjeta
        {
            set
            {
                this._tarjeta = value;
                labelNombre.Text = this._tarjeta.name;
                labelNumero.Text = this._tarjeta.number;
                labelTipo.Text = this._tarjeta.type;
            }
        }

        private void buttonBlanquearPin_Click(object sender, EventArgs e)
        {
            Controlador c = new Controlador();
            Object o = c.BlanquearPin(this._tarjeta.number);
            if (o == null)
            {
                MessageBox.Show("Hubo un error.");
            }
            else
            {
                MessageBox.Show("Se blanqueó el pin con éxito.");
            }
        }
    }
}
