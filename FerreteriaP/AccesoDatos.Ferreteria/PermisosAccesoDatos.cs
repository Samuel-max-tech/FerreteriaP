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

        public DataTable ObtenerUsuarios()
        {
            string consulta = "SELECT u.idusuario, u.usuario FROM usuarios u JOIN permisos p ON u.idusuario = p.fkidusuario";
            return conexion.ObtenerDatos(consulta);
        }

        public void GuardarPermisos(Permisos permisos)
        {
            string consulta = $"INSERT INTO permisos VALUES " +
                $"({Convert.ToInt32(permisos.Acceso)}, {Convert.ToInt32(permisos.Agregar)}, " +
                $"{Convert.ToInt32(permisos.Editar)}, {Convert.ToInt32(permisos.Eliminar)}, " +
                $"{Convert.ToInt32(permisos.Visualizar)}, {permisos.Fkidusuario})";

            conexion.EjecutarConsulta(consulta);
        }

        public void ActualizarPermisos(Permisos permisos)
        {
            string consulta = $"UPDATE permisos SET " +
                $"acceso = {Convert.ToInt32(permisos.Acceso)}, " +
                $"agregar = {Convert.ToInt32(permisos.Agregar)}, " +
                $"editar = {Convert.ToInt32(permisos.Editar)}, " +
                $"eliminar = {Convert.ToInt32(permisos.Eliminar)}, " +
                $"visualizar = {Convert.ToInt32(permisos.Visualizar)} " +
                $"WHERE fkidusuario = {permisos.Fkidusuario}";

            conexion.EjecutarConsulta(consulta);
        }
    }
}
