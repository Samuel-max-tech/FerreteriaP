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

        public DataTable ObtenerUsuariosConPermisos()
        {
            return permisosAccesoDatos.ObtenerUsuarios();
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

