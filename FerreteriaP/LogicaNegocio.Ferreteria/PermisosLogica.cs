using Entidades; // Asegúrate de que esta referencia esté presente
using AccesoDatos.Ferreteria; // Asegúrate de que esta referencia esté presente
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Ferreteria
{
    public class PermisosLogica
    {
        PermisosAccesoDatos permisosAccesoDatos;

        public PermisosLogica()
        {
            permisosAccesoDatos = new PermisosAccesoDatos();
        }

        public List<Permisos> ObtenerPermisos()
        {
            return permisosAccesoDatos.ObtenerPermisos();
        }

        public void GuardarPermisos(Permisos nuevoPermiso)
        {
            permisosAccesoDatos.GuardarPermisos(nuevoPermiso);
        }

        public List<Permisos> BuscarPermisos(string valor)
        {
            return permisosAccesoDatos.BuscarPermisos(valor);
        }

        public void ActualizarUsuarios(Permisos NuevoPermiso)
        {
            permisosAccesoDatos.ActualizarUsuarios(NuevoPermiso);
        }

        public void EliminarPermisos(int Fkidusuario)
        {
            permisosAccesoDatos.EliminarPermisos(Fkidusuario);
        }
    }
}

