using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        private bool _Acceso;
        private bool _Agregar;
        private bool _Editar;
        private bool _Eliminar;
        private bool _Visualizar;
        private int _Fkidusuario;

        public bool Acceso { get => _Acceso; set => _Acceso = value; }
        public bool Agregar { get => _Agregar; set => _Agregar = value; }
        public bool Editar { get => _Editar; set => _Editar = value; }
        public bool Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public bool Visualizar { get => _Visualizar; set => _Visualizar = value; }
        public int Fkidusuario { get => _Fkidusuario; set => _Fkidusuario = value; }
    }
}
