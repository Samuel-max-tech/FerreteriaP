using Entidades;
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
                    Nombrep = renglon["nombrep"].ToString(),
                    Descripcionp = renglon["descripcionp"].ToString(),
                    Marcap = renglon["marcap"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }
        public void GuardarProducto(Productos nuevoproducto)
        {
            string Consulta = string.Format("Insert Into productos values({0},'{1}','{2}','{3}');",
            nuevoproducto.CodigoBarras,nuevoproducto.Nombrep,nuevoproducto.Descripcionp,nuevoproducto.Marcap);
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
                    Nombrep = renglon["nombrep"].ToString(),
                    Descripcionp = renglon["descripcionp"].ToString(),
                    Marcap = renglon["marcap"].ToString(),
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
            ("update productos set nombrep='{0}',descripcionp='{1}',marcap='{2}' where CodigoBarras = {3}",NuevoProducto.Nombrep,NuevoProducto.Descripcionp,NuevoProducto.Marcap, NuevoProducto.CodigoBarras);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
