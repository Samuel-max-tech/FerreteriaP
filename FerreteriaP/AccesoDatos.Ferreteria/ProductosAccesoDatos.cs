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
        public List<Productos> ObtenerProducto()
        {
            var ListaProductos = new List<Productos>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from productos");
            foreach (DataRow renglon in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarras = int.Parse(renglon["CodigoBarras"].ToString()),
                    Nombrep = renglon["nombre"].ToString(),
                    Descripción = renglon["descripción"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
        public void GuardarProducto(Productos nuevoproducto)
        {
            string Consulta = string.Format("Insert Into productos values({0},'{1}','{2}','{3}');",
            nuevoproducto.CodigoBarras,nuevoproducto.Nombrep,nuevoproducto.Descripción,nuevoproducto.Marca);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Productos> BuscarProducto(string valor)
        {
            var ListaProductos = new List<Productos>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from productos where CodigoBarras like %{0}%", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarras = int.Parse(renglon["CodigoBarras"].ToString()),
                    Nombrep = renglon["nombre"].ToString(),
                    Descripción = renglon["descripción"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
        public void EliminarProducto(int CodigoBarras)
        {
            string consulta = string.Format("delete from productos where CodigoBarras = {0}", CodigoBarras);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarProducto(Productos NuevoProducto)
        {
            string consulta = string.Format
            ("update productos set CodigoBarras={0},nombre='{1}',descripción='{2}',marca='{3}'",
            NuevoProducto.CodigoBarras,NuevoProducto.Nombrep,NuevoProducto.Descripción,NuevoProducto.Marca);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
