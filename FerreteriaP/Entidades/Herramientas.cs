using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramientas
    {
        private int _CodigoHerramienta;
        private string _NombreH;
        private string _Medida;
        private string _MarcaH;
        private string _DescripciónH;

        public int CodigoHerramienta { get => _CodigoHerramienta; set => _CodigoHerramienta = value; }
        public string NombreH { get => _NombreH; set => _NombreH = value; }
        public string Medida { get => _Medida; set => _Medida = value; }
        public string MarcaH { get => _MarcaH; set => _MarcaH = value; }
        public string DescripciónH { get => _DescripciónH; set => _DescripciónH = value; }
    }
}
