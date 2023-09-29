using AccesoDatos.Ferreteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Ferreteria
{
    public class LogLogica
    {
        UsuariosAccesoDatos adl = new UsuariosAccesoDatos();
        public bool ValidarAcceso(string usuario, string contrasena)
        {
            if (adl.ValidarUsuario(usuario, contrasena))
                return true;
            else
                return false;
        }
    }
}
