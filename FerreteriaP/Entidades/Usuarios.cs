using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int _idUsuario;
        private string _Nombre;
        private string _Apellidop;
        private string _Apellidom;
        private string _Fechanacimiento;
        private string _Usuario;
        private string _Contrasena;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidop { get => _Apellidop; set => _Apellidop = value; }
        public string Apellidom { get => _Apellidom; set => _Apellidom = value; }
        public string Fechanacimiento { get => _Fechanacimiento; set => _Fechanacimiento = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
    }
}
