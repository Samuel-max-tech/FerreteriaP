using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Ferreteria
{
    public class PermisosAccesoDatos
    {
        Conexion conexion;

        public PermisosAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "Ferreteria", 3306);
        }

        public DataTable ObtenerNombresUsuarios()
        {
            string consulta = "SELECT usuario FROM usuarios";
            return conexion.ObtenerDatos(consulta);
        }
        public List<Usuarios> ObtenerUsuariosConPermisos()
        {
            List<Usuarios> usuariosConPermisos = new List<Usuarios>();

            string consulta = "SELECT idusuario, nombre, apellidop, apellidom, fechanacimiento, rfc, usuario FROM usuarios";
            DataTable dt = conexion.ObtenerDatos(consulta);

            foreach (DataRow row in dt.Rows)
            {
                Usuarios usuario = new Usuarios
                {
                    IdUsuario = Convert.ToInt32(row["idusuario"]),
                    Nombre = row["nombre"].ToString(),
                    Apellidop = row["apellidop"].ToString(),
                    Apellidom = row["apellidom"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Usuario = row["usuario"].ToString(),
                };

                usuariosConPermisos.Add(usuario);
            }

            return usuariosConPermisos;
        }
        public void GuardarPermisos(Permisos nuevopermiso)
        {
            string consulta = string.Format("INSERT INTO permisos VALUES ({0},{1},{2},{3},{4},{5})",
            nuevopermiso.Acceso, nuevopermiso.Agregar, nuevopermiso.Editar, nuevopermiso.Eliminar, nuevopermiso.Visualizar, nuevopermiso.Fkidusuario);
            conexion.EjecutarConsulta(consulta);
        }

        public void ActualizarPermisos(Permisos nuevopermiso)
        {
            string consulta = string.Format("Update permisos set acceso = {0}, agregar = {1}, editar = {2}, eliminar = {3}, visualizar= {4} where fkidusuario = {5})",
            nuevopermiso.Acceso, nuevopermiso.Agregar, nuevopermiso.Editar, nuevopermiso.Eliminar, nuevopermiso.Visualizar, nuevopermiso.Fkidusuario);
            conexion.EjecutarConsulta(consulta);
        }
    }
}