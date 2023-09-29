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
    public partial class FrmPricipal : Form
    {
        public FrmPricipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios fa = new FrmAgregarUsuarios();
            fa.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto fa = new FrmAgregarProducto();
            fa.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta fa = new FrmAgregarHerramienta();
            fa.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
