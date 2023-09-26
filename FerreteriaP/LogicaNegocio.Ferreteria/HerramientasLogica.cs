using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos.Ferreteria;

namespace LogicaNegocio.Ferreteria
{
    public class HerramientasLogica
    {
        private HerramientasAccesoDatos _herramientasaccesodatos;
        public HerramientasLogica()
        {
            _herramientasaccesodatos = new HerramientasAccesoDatos();
        }
        public List<Herramientas> ObtenerHerramientas()
        {
            return _herramientasaccesodatos.ObtenerHerramienta();
        }
        public List<Herramientas> BuscarHerramienta(int valor)
        {
            return _herramientasaccesodatos.BuscarHerramienta(valor);
        }
        public void GuardarHerramienta(Herramientas nuevaherramienta)
        {
            _herramientasaccesodatos.GuardarHerramienta(nuevaherramienta);
        }
        public void ActualizarProducto(Herramientas herramienta)
        {
            _herramientasaccesodatos.ActualizarHerramienta(herramienta);
        }
        public void EliminarHerramienta(int CodigoHerramienta)
        {
            _herramientasaccesodatos.EliminarHerramienta(CodigoHerramienta);
        }
        public Tuple<bool, string> ValidarHerramienta(Herramientas nuevaherramienta)
        {
            string mensaje = "";
            bool valida = true;
            if (nuevaherramienta.CodigoHerramienta.ToString() == "")
            {
                mensaje = mensaje + "El Campo Codigo de herramienta es Reqerido \n";
                valida = false;
            }

            if (nuevaherramienta.NombreH == "")
            {
                mensaje = mensaje + "El Campo Nombre es Reqerido \n";
                valida = false;
            }

            if (nuevaherramienta.Medida == "")
            {
                mensaje = mensaje + "El Campo Medida es Reqerido \n";
                valida = false;
            }

            if (nuevaherramienta.MarcaH == "")
            {
                mensaje = mensaje + "El Campo Marca es Reqerido \n";
                valida = false;
            }
            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}
