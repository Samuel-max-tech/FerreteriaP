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
        private string _Descripción;
        private string _Marca;

        public int CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Nombrep { get => _Nombrep; set => _Nombrep = value; }
        public string Descripción { get => _Descripción; set => _Descripción = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
    }
}
