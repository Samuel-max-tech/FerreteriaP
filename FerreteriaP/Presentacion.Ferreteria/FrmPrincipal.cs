using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ferreteria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios fa = new FrmAgregarUsuarios();
            fa.ShowDialog();
        }

        private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
