using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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
                };
                ListaUsuarios.Add(usuario);
            }
            return ListaUsuarios;
        }
        public void GuardarUsuario(Usuarios nuevousuario)
        {
            string Consulta = string.Format("Insert Into usuarios values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
            nuevousuario.Nombre,nuevousuario.Apellidop,nuevousuario.Apellidom,
            nuevousuario.Fechanacimiento,nuevousuario.Rfc,nuevousuario.Usuario,nuevousuario.Contrasena);
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
            string consulta = string.Format
            ("update usuarios set nombre='{0}',apellidop='{1}',apellidom='{2}',fechanacimiento='{3}',rfc='{4}',usuario='{5}',contrasena='{6}' where idusuario={7}",
            NuevoUsuario.Nombre,NuevoUsuario.Apellidop,NuevoUsuario.Apellidom,NuevoUsuario.Fechanacimiento,NuevoUsuario.Rfc,NuevoUsuario.Usuario,NuevoUsuario.Contrasena,
            NuevoUsuario.IdUsuario);
            conexion.EjecutarConsulta(consulta);
        }

    }
}
