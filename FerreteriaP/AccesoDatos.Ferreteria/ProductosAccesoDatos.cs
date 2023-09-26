﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Ferreteria
{
    public class ProductosAccesoDatos
    {
        Conexion conexion;
        public ProductosAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "Ferreteria", 3306);
        }
        public List<Productos> ObtenerPermisos()
        {
            var ListaProductos = new List<Productos>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from productos");
            foreach (DataRow renglon in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarras = Convert.ToInt32(renglon["CodigoBarras"]),
                    Nombrep = renglon["nombre"].ToString(),
                    Descripción = renglon["descripción"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
        public void GuardarProductos(Productos nuevoproducto)
        {
            string Consulta = string.Format("Insert Into productos values('{0}','{1}','{2}','{3}','{4}');",
            nuevoproducto.CodigoBarras,nuevoproducto.Nombrep,nuevoproducto.Descripción,nuevoproducto.Marca);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Productos> BuscarProdductos(string valor)
        {
            var ListaProductos = new List<Productos>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from productos where CodigoBarras like %'{0}'%", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarras = Convert.ToInt32(renglon["CodigoBarras"]),
                    Nombrep = renglon["nombre"].ToString(),
                    Descripción = renglon["descripción"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
        public void EliminarProductos(string CodigoBarras)
        {
            string consulta = string.Format("delete from productos where CodigoBarras = '{0}'", CodigoBarras);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarProductos(Productos NuevoProducto)
        {
            string consulta = string.Format
            ("update productos set CodigoBarras='{0}',nombre='{1}',agregar={2},descripción='{3}',marca='{4}'",
            NuevoProducto.CodigoBarras,NuevoProducto.Nombrep,NuevoProducto.Descripción,NuevoProducto.Marca);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
