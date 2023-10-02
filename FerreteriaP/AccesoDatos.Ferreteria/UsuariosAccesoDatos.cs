using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Security.Cryptography;

namespace AccesoDatos.Ferreteria
{
    public class UsuariosAccesoDatos
    {
        Conexion conexion;
        public UsuariosAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "Ferreteria", 3306);
        }
        public List<Usuarios> ObtenerUsuarios()
        {
            var ListaUsuarios = new List<Usuarios>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from usuarios");
            foreach (DataRow renglon in dt.Rows)
            {
                var usuario = new Usuarios
                {
                    IdUsuario = Convert.ToInt32(renglon["idusuario"]),
                    Nombre = renglon["nombre"].ToString(),
                    Apellidop = renglon["apellidop"].ToString(),
                    Apellidom = renglon["apellidom"].ToString(),
                    Fechanacimiento = renglon["fechanacimiento"].ToString(),
                    Rfc = renglon["rfc"].ToString(),
                    Usuario = renglon["usuario"].ToString(),
                    Contrasena = renglon["contrasena"].ToString(),
                    Acceso = bool.Parse(renglon["acceso"].ToString()),
                    Agregar = bool.Parse(renglon["agregar"].ToString()),
                    Editar = bool.Parse(renglon["editar"].ToString()),
                    Eliminar = bool.Parse(renglon["eliminar"].ToString()),
                    Visualizar = bool.Parse(renglon["visualizar"].ToString())
                };
                ListaUsuarios.Add(usuario);
            }
            return ListaUsuarios;
        }
        public void GuardarUsuario(Usuarios nuevousuario)
        {
            string Consulta = string.Format("Insert Into usuarios values(null,'{0}','{1}','{2}','{3}','{4}','{5}',Sha1('{6}'),{7},{8},{9},{10},{11});",
            nuevousuario.Nombre,nuevousuario.Apellidop,nuevousuario.Apellidom,nuevousuario.Fechanacimiento,nuevousuario.Rfc,nuevousuario.Usuario,nuevousuario.Contrasena,nuevousuario.Acceso,
            nuevousuario.Agregar,nuevousuario.Editar,nuevousuario.Eliminar,nuevousuario.Visualizar);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Usuarios> BuscarUsuario(string valor)
        {
            var ListaUsuarios = new List<Usuarios>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from usuarios where nombre like '%{0}%'", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var usuario = new Usuarios
                {
                    IdUsuario = Convert.ToInt32(renglon["idusuario"]),
                    Nombre = renglon["nombre"].ToString(),
                    Apellidop = renglon["apellidop"].ToString(),
                    Apellidom = renglon["apellidom"].ToString(),
                    Fechanacimiento = renglon["fechanacimiento"].ToString(),
                    Rfc = renglon["rfc"].ToString(),
                    Usuario = renglon["usuario"].ToString(),
                    Contrasena = renglon["contrasena"].ToString(),
                    Acceso = bool.Parse(renglon["acceso"].ToString()),
                    Agregar = bool.Parse(renglon["agregar"].ToString()),
                    Editar = bool.Parse(renglon["editar"].ToString()),
                    Eliminar = bool.Parse(renglon["eliminar"].ToString()),
                    Visualizar = bool.Parse(renglon["visualizar"].ToString())
                };
                ListaUsuarios.Add(usuario);
            }
            return ListaUsuarios;
        }
        public void EliminarUsuarios(int idusuario)
        {
            string consulta = string.Format("delete from usuarios where idusuario = {0}", idusuario);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarUsuarios(Usuarios NuevoUsuario)
        {
            string consulta = string.Format("update usuarios set nombre='{0}',apellidop='{1}',apellidom='{2}',fechanacimiento='{3}',rfc='{4}',usuario='{5}',contrasena=sha1('{6}'),acceso={7},agregar={8},editar={9},eliminar={10},visualizar={11} where idusuario={12} ",
            NuevoUsuario.Nombre,NuevoUsuario.Apellidop,NuevoUsuario.Apellidom,NuevoUsuario.Fechanacimiento,NuevoUsuario.Rfc,NuevoUsuario.Usuario,NuevoUsuario.Contrasena,NuevoUsuario.Acceso, NuevoUsuario.Agregar, NuevoUsuario.Editar, NuevoUsuario.Eliminar, NuevoUsuario.Visualizar, NuevoUsuario.IdUsuario);
            conexion.EjecutarConsulta(consulta);
        }

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            string hashedPassword = Sha1(contrasena);
            string consulta = $"SELECT * FROM usuarios WHERE usuario = '{usuario}' AND contrasena = '{hashedPassword}'";
            DataTable dt = conexion.ObtenerDatos(consulta);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = Encoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
