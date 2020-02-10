using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinal.Controladores;
using TPFinal.DAL;

namespace TPFinal
{
    public partial class ucTarjeta : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private Product _tarjeta;
        ControladorOperacion iControladorOperacion;
        ControladorUsuario iControladorUsuario;
        Controlador iControlador = new Controlador();

        public ucTarjeta()
        {
            log.Debug("Inicializando ucTarjeta...");
            InitializeComponent();
            iControladorOperacion = new ControladorOperacion(UnidadDeTrabajo.Instancia);
            iControladorUsuario = new ControladorUsuario(UnidadDeTrabajo.Instancia);
            log.Debug("ucTarjeta inicializado.");
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
            log.Debug("Blanqueando Pin...");
            Controlador c = new Controlador();
            Object o = c.BlanquearPin(this._tarjeta.number);
            if (o == null)
            {
                log.Error("Error al blanquear Pin.");
                MessageBox.Show("Hubo un error.");
            }
            else
            {
                log.Info("Pin blanqueado.");
                log.Debug("Registrando tiempo...");
                Usuario iUsuario=iControlador.ObtenerUsuario(this);
                if (iControladorUsuario.UsuarioYaExiste(iUsuario))
                    iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
                else
                {
                    iControladorUsuario.RegistrarUsuario(iUsuario);
                    iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
                }    
                iControladorOperacion.RegistrarOperacion("Blanqueo de pin", iControlador.ObtenerTiempoAplicacion(this), iUsuario);
                log.Debug("Tiempo registrado.");
                MessageBox.Show("Se blanqueó el pin con éxito.");

                log.Debug("Saliendo de aplicación...");
                Application.Restart();
            }
        }
    }
}
