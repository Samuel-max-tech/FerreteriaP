using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Ferreteria
{
    public class HerramientasAccesoDatos
    {
        Conexion conexion;
        public HerramientasAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "Ferreteria", 3306);
        }
        public List<Herramientas> ObtenerHerramienta()
        {
            var ListaHerramientas = new List<Herramientas>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from herramientas");
            foreach (DataRow renglon in dt.Rows)
            {
                var herramientas = new Herramientas
                {
                    CodigoHerramienta = Convert.ToInt32(renglon["CodigoHerramienta"]),
                    NombreH = renglon["nombre"].ToString(),
                    Medida = renglon["medida"].ToString(),
                    MarcaH = renglon["marca"].ToString(),
                    DescripciónH = renglon["descripción"].ToString(),
                };
                ListaHerramientas.Add(herramientas);
            }
            return ListaHerramientas;
        }
        public void GuardarHerramienta(Herramientas nuevaherramienta)
        {
            string Consulta = string.Format("Insert Into herramientas values({0},'{1}','{2}','{3}','{4}');",
            nuevaherramienta.CodigoHerramienta,nuevaherramienta.NombreH,
            nuevaherramienta.Medida,nuevaherramienta.MarcaH,nuevaherramienta.DescripciónH);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Herramientas> BuscarHerramienta(int valor)
        {
            var ListaHerramientas = new List<Herramientas>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from herramientas where CodigoHerramienta like %{0}%", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var herramienta = new Herramientas
                {
                    CodigoHerramienta = Convert.ToInt32(renglon["CodigoHerramienta"]),
                    NombreH = renglon["nombre"].ToString(),
                    Medida = renglon["medida"].ToString(),
                    MarcaH = renglon["marca"].ToString(),
                    DescripciónH = renglon["descripción"].ToString(),
                };
                ListaHerramientas.Add(herramienta);
            }
            return ListaHerramientas;
        }
        public void EliminarHerramienta(int CodigoHerramienta)
        {
            string consulta = string.Format("delete from herramientas where CodigoHerramienta ={0}", CodigoHerramienta);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarHerramienta(Herramientas NuevaHerramienta)
        {
            string consulta = string.Format
            ("update herramietnas set CodigoHerramienta='{0}',nombre='{1}',medida={2},marca='{3}',descripción='{4}'",
            NuevaHerramienta.CodigoHerramienta,NuevaHerramienta.NombreH,
            NuevaHerramienta.Medida,NuevaHerramienta.MarcaH,NuevaHerramienta.DescripciónH);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
