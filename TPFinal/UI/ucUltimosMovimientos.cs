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
    public partial class ucUltimosMovimientos : UserControl
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        private static ucUltimosMovimientos _instancia;

        private List<Movement> _movimientos;

        ControladorOperacion iControladorOperacion;
        ControladorUsuario iControladorUsuario;
        Controlador iControlador = new Controlador();

        public ucUltimosMovimientos()
        {
            log.Debug("Inicializando ucUltimosMovimientos...");
            InitializeComponent();
            iControladorOperacion = new ControladorOperacion(UnidadDeTrabajo.Instancia);
            iControladorUsuario = new ControladorUsuario(UnidadDeTrabajo.Instancia);
            log.Debug("ucUltimosMovimientos inicializado.");
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
            log.Debug("Cargando movimientos...");
            foreach (Movement m in _movimientos)
            {
                ucMovimiento movimiento = new ucMovimiento();
                movimiento.Movimiento = m;
                movimiento.Dock = DockStyle.Top;
                movimiento.BringToFront();
                tableLayoutPanel2.Controls.Add(movimiento);
            }
            log.Info("Movimientos cargados.");

            //Se carga la operacion en la base de datos una vez finalizados de cargar los datos en pantalla
            log.Debug("Registrando tiempo...");
            Usuario iUsuario = iControlador.ObtenerUsuario(this);
            if (iControladorUsuario.UsuarioYaExiste(iUsuario))
                iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
            else
            {
                iControladorUsuario.RegistrarUsuario(iUsuario);
                iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
            }
            iControladorOperacion.RegistrarOperacion("Consulta ultimos movimientos", iControlador.ObtenerTiempoAplicacion(this), iUsuario);
            log.Debug("Tiempo registrado.");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            log.Debug("Saliendo de aplicación...");
            Application.Restart();
        }
    }
}
