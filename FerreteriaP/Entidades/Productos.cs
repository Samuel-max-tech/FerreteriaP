using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        private int _CodigoBarras;
        private string _Nombrep;
        private string _Descripcion;
        private string _Marca;

        public int CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Nombrep { get => _Nombrep; set => _Nombrep = value; }
        public string Descripcionp { get => _Descripcion; set => _Descripcion = value; }
        public string Marcap { get => _Marca; set => _Marca = value; }
    }
}
