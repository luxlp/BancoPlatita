using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Mover pantalla al arrastrar desde título
        private bool mouseApretado;
        private Point lugarAnterior;

        private void panelTitular_MouseDown(object sender, MouseEventArgs e)
        {
            mouseApretado = true;
            lugarAnterior = e.Location;
        }

        private void panelTitular_MouseUp(object sender, MouseEventArgs e)
        {
            mouseApretado = false;
        }

        private void panelTitular_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseApretado)
        {
                this.Location = new Point(
                    (this.Location.X - lugarAnterior.X) + e.X, (this.Location.Y - lugarAnterior.Y) + e.Y);

                this.Update();
            }
        }
        // ---

        // Para uso durante desarrollo
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // ---

        // Con estos trato de manejar el flujo
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Ayudante.CargarIngresoDni(panelTexto, buttonSiguiente);
            Ayudante.CargarTeclado(panelEntrada);

            buttonSiguiente.Click += buttonSiguientePin_Click;
        }

        private void buttonSiguientePin_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(panelTexto);
            Ayudante.CargarIngresoPin(panelTexto, buttonSiguiente);
            Ayudante.CargarTeclado(panelEntrada);

            buttonSiguiente.Click -= buttonSiguientePin_Click;
            buttonSiguiente.Click += buttonSiguienteLogin_Click;
        }

        private void buttonSiguienteLogin_Click(object sender, EventArgs e)
        {
            Controlador c = new Controlador();
            Usuario u = c.Login(Ayudante.Dni, Ayudante.Pin);
            if (u != null){
                labelNombreUsuario.Text = $"Bienvenido {u.Nombre}";
                labelCategoriaUsuario.Text = u.Categoria;
                Ayudante.MostrarContenidoPanel(panelUsuario);

                Ayudante.EsconderContenidoPanel(panelContenido);
                Ayudante.CargarOperaciones(panelContenido);
            }
            // reducir contador de intentos. cuando contador == 0, reiniciar.
            // pero para esto falta la funcionalidad para volver
            else
            {
                MessageBox.Show("No se pudo iniciar sesión. El DNI o PIN es incorrecto.");
                Application.Restart();
            }
        }

        // TO-DO
        /*
        private void buttonAnteriorPin_Click(object sender, EventArgs e)
        {
            Ayudante.EsconderContenidoPanel(panelContenido);
            Ayudante.CargarOperaciones(panelContenido);
        }
        */
    }
}
