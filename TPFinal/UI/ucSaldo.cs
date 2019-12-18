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
    public partial class ucSaldo : UserControl
    {
        private static ucSaldo _instancia;
        private float _saldo;

        ControladorOperacion iControladorOperacion;
        ControladorUsuario iControladorUsuario;
        Controlador iControlador = new Controlador();

        public ucSaldo()
        {
            InitializeComponent();
            iControladorOperacion = new ControladorOperacion(UnidadDeTrabajo.Instancia);
            iControladorUsuario = new ControladorUsuario(UnidadDeTrabajo.Instancia);
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


            //Se cargan la operacion en la base de datos una vez finalizados de cargar los datos en pantalla
            Usuario iUsuario = iControlador.ObtenerUsuario(this);
            if (iControladorUsuario.UsuarioYaExiste(iUsuario))
                iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
            else
            {
                iControladorUsuario.RegistrarUsuario(iUsuario);
                iUsuario = iControladorUsuario.ObtenerUsuario(iUsuario.Nombre, iUsuario.Categoria);
            }
            iControladorOperacion.RegistrarOperacion("Consulta saldo", iControlador.ObtenerTiempoAplicacion(this), iUsuario);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
