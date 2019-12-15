using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    class Ayudante
    {
        private Ayudante() { }

        public static String Dni { get { return ucDni.Instancia.CajaTexto.Text; } }
        public static String Pin { get { return ucPin.Instancia.CajaTexto.Text; } }
               
        private static TextBoxBase _cajaTextoActual;

        public static void EsconderContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = false;
                c.Visible = false;
            }
        }

        public static void MostrarContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = true;
                c.Visible = true;
            }
        }

        public static void CargarTeclado(Panel p)
        {
            ucNumpad numpad = ucNumpad.Instancia;
            if (!p.Controls.Contains(numpad))
            {
                p.Controls.Add(numpad);
                numpad.Dock = DockStyle.Fill;
                numpad.BringToFront();
            }
            ucNumpad.CajaTexto = _cajaTextoActual;
        }

        public static void CargarIngresoDni(Panel p, ButtonBase b)
        {
            ucDni dni = ucDni.Instancia;
            if (!p.Controls.Contains(dni))
            {
                p.Controls.Add(dni);
                dni.Dock = DockStyle.Fill;
                dni.BringToFront();
                dni.BotonSiguiente = b;
                _cajaTextoActual = dni.CajaTexto;
            }
        }

        public static void CargarIngresoPin(Panel p, ButtonBase b)
        {
            ucPin pin = ucPin.Instancia;
            if (!p.Controls.Contains(pin))
            {
                p.Controls.Add(pin);
                pin.Dock = DockStyle.Fill;
                pin.BringToFront();
                pin.BotonSiguiente = b;
                _cajaTextoActual = pin.CajaTexto;
            }
        }

        public static void CargarOperaciones(Panel p)
        {
            ucOperaciones op = ucOperaciones.Instancia;
            if (!p.Controls.Contains(op))
            {
                p.Controls.Add(op);
                op.Dock = DockStyle.Fill;
                op.BringToFront();
                op.Dni = Dni;
                op.Contenedor = p;
                _cajaTextoActual = null;
            }
        }

        public static void CargarTarjetas(Panel p)
        {
            Controlador c = new Controlador();
            List<Product> t = c.ObtenerTarjetas(Dni);
            if (t != null)
            {
                ucBlanquear blanq = ucBlanquear.Instancia;
                if (!p.Controls.Contains(blanq))
                {
                    p.Controls.Add(blanq);
                    blanq.Dock = DockStyle.Fill;
                    blanq.BringToFront();
                    blanq.Tarjetas = t;
                }
            }
            else
            {
                MessageBox.Show("No se pudo recuperar información sobre las tarjetas.");
            }
        }

        public static void CargarMovimientos(Panel p)
        {
            Controlador c = new Controlador();
            List<Movement> m = c.UltimosMovimientos(Dni);
            if (m != null)
            {
                ucUltimosMovimientos ultmov = ucUltimosMovimientos.Instancia;
                if (!p.Controls.Contains(ultmov))
                {
                    p.Controls.Add(ultmov);
                    ultmov.Dock = DockStyle.Fill;
                    ultmov.BringToFront();
                    ultmov.Movimientos = m;
                }
            }
            else
            {
                MessageBox.Show("No se pudo recuperar información sobre los movimientos.");
            }
        }

        public static void CargarSaldo(Panel p)
        {
            Controlador c = new Controlador();
            float? s = c.SaldoCuentaCorriente(Dni);
            if (s != null)
            {
                ucSaldo saldo = ucSaldo.Instancia;
                if (!p.Controls.Contains(saldo))
                {
                    p.Controls.Add(saldo);
                    saldo.Dock = DockStyle.Fill;
                    saldo.BringToFront();
                    saldo.Saldo = (float)s;
                }
            }
        }
    }
}
