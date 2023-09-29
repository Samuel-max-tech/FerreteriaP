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
        UsuariosAccesoDatos adl;
        public bool ValidarAcceso(string usuario, string clave)
        {
            if (adl.ValidarUsuario(usuario, clave))
                return true;
            else
                return false;
        }
    }
}
