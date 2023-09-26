using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos.Ferreteria;

namespace LogicaNegocio.Ferreteria
{
    public class ProductosLogica
    {
        private ProductosAccesoDatos _productosaccesodatos;
        public ProductosLogica()
        {
            _productosaccesodatos = new ProductosAccesoDatos();
        }
        public List<Productos> ObtenerProducto()
        {
            return _productosaccesodatos.ObtenerProducto();
        }
        public List<Productos> BuscarProducto(string valor)
        {
            return _productosaccesodatos.BuscarProducto(valor);
        }
        public void GuardarProducto(Productos nuevoproducto)
        {
            _productosaccesodatos.GuardarProducto(nuevoproducto);
        }
        public void ActualizarProducto(Productos producto)
        {
            _productosaccesodatos.ActualizarProducto(producto);
        }
        public void EliminarProducto(int CodigoBarras)
        {
            _productosaccesodatos.EliminarProducto(CodigoBarras);
        }
        public Tuple<bool, string> ValidarProducto(Productos nuevoproducto)
        {
            string mensaje = "";
            bool valida = true;
            if (nuevoproducto.CodigoBarras.ToString() == "")
            {
                mensaje = mensaje + "El Campo Codigo de barras es Reqerido \n";
                valida = false;
            }

            if (nuevoproducto.Nombrep == "")
            {
                mensaje = mensaje + "El Campo Nombre es Reqerido \n";
                valida = false;
            }

            if (nuevoproducto.Marca == "")
            {
                mensaje = mensaje + "El Campo Marca es Reqerido \n";
                valida = false;
            }
            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}
