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
using TPFinal.DTO;

namespace TPFinal
{
    public partial class ucTarjeta : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private Producto _tarjeta;
        ControladorOperacion iControladorOperacion;
        ControladorUsuario iControladorUsuario;
        Fachada iFachada = new Fachada();

        public ucTarjeta()
        {
            log.Debug("Inicializando ucTarjeta...");
            InitializeComponent();
            iControladorOperacion = new ControladorOperacion(UnidadDeTrabajo.Instancia);
            iControladorUsuario = new ControladorUsuario(UnidadDeTrabajo.Instancia);
            log.Debug("ucTarjeta inicializado.");
        }

        public Producto Tarjeta
        {
            set
            {
                this._tarjeta = value;
                labelNombre.Text = this._tarjeta.nombre;
                labelNumero.Text = this._tarjeta.numero;
                labelTipo.Text = this._tarjeta.tipo;
            }
        }

        private void buttonBlanquearPin_Click(object sender, EventArgs e)
        {
            log.Debug("Blanqueando Pin...");
            Fachada iFachada = new Fachada();
            Object o = iFachada.BlanquearPin(this._tarjeta.numero);
            if (o == null)
            {
                log.Error("Error al blanquear Pin.");
                MessageBox.Show("Hubo un error.");
            }
            else
            {
                log.Info("Pin blanqueado.");
                log.Debug("Registrando tiempo...");
                DTOUsuario iUsuario= iFachada.ObtenerUsuario(this);
                
                iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
                 
                iControladorOperacion.RegistrarOperacion("Blanqueo de pin", iFachada.ObtenerTiempoAplicacion(this), iUsuario);
                log.Debug("Tiempo registrado.");
                MessageBox.Show("Se blanqueó el pin con éxito.");

                log.Debug("Saliendo de aplicación...");
                Application.Restart();
            }
        }
    }
}
