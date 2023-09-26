using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        private string _CodigoBarras;
        private string _Nombre;
        private string _Descripción;
        private string _Marca;

        public string CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripción { get => _Descripción; set => _Descripción = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
    }
}
