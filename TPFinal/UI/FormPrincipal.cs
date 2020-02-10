using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TPFinal
{
    public partial class FormPrincipal : Form
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        public FormPrincipal()
        {
            log.Debug("Inicializando FormPrincipal...");
            InitializeComponent();
            log.Debug("FormPrincipal inicializado.");
        }

        // Mover pantalla al arrastrar desde título
        private bool mouseApretado;
        private Point lugarAnterior;
        public Usuario iUsuario { get; set; }
        public Stopwatch iCronometro { get; set; } 

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
        // ---.

        // Para uso durante desarrollo
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            log.Debug("Saliendo de aplicación...");
            Application.Exit();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // ---.

        // Con estos trato de manejar el flujo
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            iCronometro = new Stopwatch();
            iCronometro.Start();
            log.Debug("Cronometro en marcha.");

            log.Debug("Cargando IngresoDni...");
            Ayudante.CargarIngresoDni(panelTexto, buttonSiguiente);
            Ayudante.CargarTeclado(panelEntrada);
            log.Debug("IngresoDni cargado.");

            buttonSiguiente.Click += buttonSiguientePin_Click;
            log.Debug("Siguiente: Ingreso de Pin.");
        }

        private void buttonSiguientePin_Click(object sender, EventArgs e)
        {
            log.Debug("Cargando IngresoPin...");
            Ayudante.EsconderContenidoPanel(panelTexto);
            Ayudante.CargarIngresoPin(panelTexto, buttonSiguiente);
            Ayudante.CargarTeclado(panelEntrada);
            log.Debug("IngresoPin cargado.");

            buttonSiguiente.Click -= buttonSiguientePin_Click;
            buttonSiguiente.Click += buttonSiguienteLogin_Click;
            log.Debug("Siguiente: Login.");
        }

        private void buttonSiguienteLogin_Click(object sender, EventArgs e)
        {
            log.Debug("Cargando Usuario...");
            Controlador c = new Controlador();
            iUsuario = c.Login(Ayudante.Dni, Ayudante.Pin);
            log.Debug("Usuario cargado.");

            if (iUsuario != null){
                log.Info("Usuario valido.");
                log.Debug("Cargando Operaciones...");
                labelNombreUsuario.Text = $"Bienvenido {iUsuario.Nombre}";
                labelCategoriaUsuario.Text = iUsuario.Categoria;
                Ayudante.MostrarContenidoPanel(panelUsuario);
                Ayudante.EsconderContenidoPanel(panelContenido);
                Ayudante.CargarOperaciones(panelContenido);
                log.Debug("Opciones cargadas.");
            }
            // reducir contador de intentos. cuando contador == 0, reiniciar.
            // pero para esto falta la funcionalidad para volver
            else
            {
                log.Info("Usuario nulo.");
                MessageBox.Show("No se pudo iniciar sesión. El DNI o PIN es incorrecto.");

                log.Debug("Reiniciando aplicacion...");
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
