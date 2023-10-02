using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio.Ferreteria;

namespace Presentacion.Ferreteria
{
    public partial class FrmLog : Form
    {
        PermisosLogica prgl;
        string[] arreglo = null;
        public string usuario = "";
        Permisos permisos = new Permisos();
        PermisosLogica perlog;
        LogLogica log;
        public FrmLog()
        {
            InitializeComponent();
            log = new LogLogica();
            perlog = new PermisosLogica();
            prgl = new PermisosLogica();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (log.ValidarAcceso(txtUsuario.Text, txtContrasena.Text))
            {
                    Permisos(txtUsuario.Text);
                    FrmPricipal p = new FrmPricipal(arreglo[0], arreglo[1], arreglo[2], arreglo[3], arreglo[4]);
                    Hide();
                    txtUsuario.Text = usuario;
                    p.ShowDialog();
                    this.Close();
                }
            else
                MessageBox.Show("Error de credenciales");
        }
        private void lblAddUser_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios fa = new FrmAgregarUsuarios();
            fa.ShowDialog();
        }
        private void Permisos(string usuarios)
        {
            string permisos = prgl.Permisos(usuarios);
            arreglo = permisos.Split(',');
        }
    }
}
