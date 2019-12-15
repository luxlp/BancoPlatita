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
    public partial class ucUltimosMovimientos : UserControl
    {
        private static ucUltimosMovimientos _instancia;

        private List<Movement> _movimientos;

        public ucUltimosMovimientos()
        {
            InitializeComponent();
        }

        public static ucUltimosMovimientos Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ucUltimosMovimientos();
                }
                return _instancia;
            }
        }

        public List<Movement> Movimientos
        {
            set
            {
                _movimientos = value;
                CargarMovimientos();
            }
        }

        private void CargarMovimientos()
        {
            foreach (Movement m in _movimientos)
            {
                ucMovimiento movimiento = new ucMovimiento();
                movimiento.Movimiento = m;
                movimiento.Dock = DockStyle.Top;
                movimiento.BringToFront();
                tableLayoutPanel2.Controls.Add(movimiento);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
