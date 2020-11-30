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
    public partial class ucSaldo : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private static ucSaldo _instancia;
        private float _saldo;

        ControladorOperacion iControladorOperacion;
        ControladorUsuario iControladorUsuario;
        Fachada iFachada = new Fachada();

        public ucSaldo()
        {
            log.Debug("Inicializando ucSaldo...");
            InitializeComponent();
            iControladorOperacion = new ControladorOperacion(UnidadDeTrabajo.Instancia);
            iControladorUsuario = new ControladorUsuario(UnidadDeTrabajo.Instancia);
            log.Debug("ucSaldo inicializado.");
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
            log.Debug("Mostrando saldo...");
            labelSaldo.Text = Convert.ToString(_saldo);
            log.Info("Saldo mostrado.");

            //Se cargan la operacion en la base de datos una vez finalizados de cargar los datos en pantalla
            log.Debug("Registrando tiempo...");
            DTOUsuario iUsuario = iFachada.ObtenerUsuario(this);
            
            iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
            
            iControladorOperacion.RegistrarOperacion("Consulta saldo", iControlador.ObtenerTiempoAplicacion(this), iUsuario);
            log.Debug("Tiempo registrado.");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            log.Debug("Saliendo de aplicación...");
            Application.Restart();
        }
    }
}
