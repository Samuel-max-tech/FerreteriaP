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
        public List<Permisos> ObtenerPermisos()
        {
            var ListaPermisos = new List<Permisos>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from permisos");
            foreach (DataRow renglon in dt.Rows)
            {
                var permiso = new Permisos
                {
                    Acceso =bool.Parse(renglon["acceso"].ToString()),
                    Agregar = bool.Parse(renglon["agregar"].ToString()),
                    Editar = bool.Parse(renglon["editar"].ToString()),
                    Eliminar = bool.Parse(renglon["eliminar"].ToString()),
                    Visualizar = bool.Parse(renglon["visualizar"].ToString()),
                    Fkidusuario = Convert.ToInt32(renglon["fkidusuario"]),
                };
                ListaPermisos.Add(permiso);
            }
            return ListaPermisos;
        }
        public void GuardarPermisos(Permisos nuevopermiso)
        {
            string Consulta = string.Format("Insert Into permisos values({0},{1},{2},{3},{4},{5},{6});",
            nuevopermiso.Acceso,nuevopermiso.Agregar,nuevopermiso.Editar,
            nuevopermiso.Eliminar,nuevopermiso.Visualizar,nuevopermiso.Fkidusuario);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Permisos> BuscarPermisos(string valor)
        {
            var ListaPermisos = new List<Permisos>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from permisos where fkidusuario like %{0}%", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var usuario = new Permisos
                {
                    Fkidusuario = Convert.ToInt32(renglon["fkidusuario"]),
                    Acceso = bool.Parse(renglon["acceso"].ToString()),
                    Agregar = bool.Parse(renglon["agregar"].ToString()),
                    Editar = bool.Parse(renglon["editar"].ToString()),
                    Eliminar = bool.Parse(renglon["eliminar"].ToString()),
                    Visualizar = bool.Parse(renglon["visualizar"].ToString()),
                };
                ListaPermisos.Add(usuario);
            }
            return ListaPermisos;
        }
        public void EliminarPermisos(int Fkidusuario)
        {
            string consulta = string.Format("delete from permisos where fkidusuario ={0}", Fkidusuario);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarUsuarios(Permisos NuevoPermiso)
        {
            string consulta = string.Format
            ("update permisos set fkidusuario={0},acceso={1},agregar={2},editar={3},eliminar={4},visualizar={5}",
            NuevoPermiso.Fkidusuario,NuevoPermiso.Acceso,NuevoPermiso.Agregar,NuevoPermiso.Editar,
            NuevoPermiso.Eliminar,NuevoPermiso.Visualizar);
            conexion.EjecutarConsulta(consulta);
        }

    }
}
