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
        public string Permisos(string usuario)
        {
            return permisosAccesoDatos.Permisos(usuario);
        }

    }
}