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
        public string Permisos(string usuario)
        {
            DataSet ds = conexion.Permisos(string.Format("call P_Permisos('{0}')", usuario), "USUARIOS");
            DataTable dt = ds.Tables["USUARIOS"];
            DataRow r = dt.Rows[0];
            return r["rs"].ToString();

        }
    }
}