using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.Clases;

namespace TPFinal.DAL.Interfaces
{
    interface IRepositorioUsuario : IRepositorioGeneral<Usuario>
    {
        bool UsuarioYaExiste(string pNombre, string pCategoria);
        Usuario ObtenerPorNombreyCat(string pNombre, string pCategoria);
    }
}
