using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos.Ferreteria;

namespace LogicaNegocio.Ferreteria
{
    public class UsuariosLogica
    {
        private UsuariosAccesoDatos _usuariosaccesodatos;
        public UsuariosLogica()
        {
            _usuariosaccesodatos = new UsuariosAccesoDatos();
        }
        public List<Usuarios> ObtenerUsuarios()
        {
            return _usuariosaccesodatos.ObtenerUsuarios();
        }
        public List<Usuarios> BuscarUsuario(string valor)
        {
            return _usuariosaccesodatos.BuscarUsuario(valor);
        }
        public void GuardarUsuario(Usuarios nuevousuario)
        {
            _usuariosaccesodatos.GuardarUsuario(nuevousuario);
        }
        public void ActualizarUsuarios(Usuarios usuario)
        {
            _usuariosaccesodatos.ActualizarUsuarios(usuario);
        }
        public void EliminarUsuarios(int idusuario)
        {
            _usuariosaccesodatos.EliminarUsuarios(idusuario);
        }
        public Tuple<bool, string> ValidadUsuario(Usuarios nuevousuario)
        {
            string mensaje = "";
            bool valida = true;
            if (nuevousuario.Nombre == "")
            {
                mensaje = mensaje + "El Campo nombre es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Apellidop == "")
            {
                mensaje = mensaje + "El Campo Apellido Paterno es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Apellidom == "")
            {
                mensaje = mensaje + "El Campo Apellido Materno es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Fechanacimiento == "")
            {
                mensaje = mensaje + "El Campo Fecha de Nacimiento es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Rfc == "")
            {
                mensaje = mensaje + "El Campo RFC es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Usuario == "")
            {
                mensaje = mensaje + "El Campo Usuario es Reqerido \n";
                valida = false;
            }

            if (nuevousuario.Contrasena == "")
            {
                mensaje = mensaje + "El Campo Clave es Reqerido \n";
                valida = false;
            }

            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}
