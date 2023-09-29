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
        private string _Nombreh;
        private string _Medidah;
        private string _Marcah;
        private string _Descripciónh;

        public int CodigoHerramienta { get => _CodigoHerramienta; set => _CodigoHerramienta = value; }
        public string Nombreh { get => _Nombreh; set => _Nombreh = value; }
        public string Medidah { get => _Medidah; set => _Medidah = value; }
        public string Marcah { get => _Marcah; set => _Marcah = value; }
        public string Descripcionh { get => _Descripciónh; set => _Descripciónh = value; }
    }
}
