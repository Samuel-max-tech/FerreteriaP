using Entidades; 
using AccesoDatos.Ferreteria; 
using System;
using System.Collections.Generic;
using System.Data;

namespace LogicaNegocio.Ferreteria
{
    public class PermisosLogica
    {
        PermisosAccesoDatos permisosAccesoDatos;

        public PermisosLogica()
        {
            permisosAccesoDatos = new PermisosAccesoDatos();
        }

        public List<string> ObtenerNombresUsuariosConPermisos()
        {
            List<string> nombresUsuarios = new List<string>();

            DataTable dt = permisosAccesoDatos.ObtenerNombresUsuarios();

            foreach (DataRow fila in dt.Rows)
            {
                nombresUsuarios.Add(fila["usuario"].ToString());
            }

            return nombresUsuarios;
        }
        public List<Usuarios> ObtenerUsuariosConPermisos()
        {
            List<Usuarios> usuariosConPermisos = permisosAccesoDatos.ObtenerUsuariosConPermisos();

            return usuariosConPermisos;
        }
        public void GuardarPermisos(Permisos permisos)
        {
            permisosAccesoDatos.GuardarPermisos(permisos);
        }

        public void ActualizarPermisos(Permisos permisos)
        {
            permisosAccesoDatos.ActualizarPermisos(permisos);
        }
    }
}

