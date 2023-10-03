using Entidades;
using LogicaNegocio.Ferreteria;
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
        public bool acceso = false;
        public bool agregar = false;
        public bool editar = false;
        public bool eliminar = false;
        public bool visualiar = false;
        public FrmPricipal(string acc,string ag, string ed, string el, string vis)
        {
            InitializeComponent();
            permisos(acc, ag, ed, el, vis);
        }
        private void permisos(string acc, string ag, string ed, string el,string vis)
        {
            if (acc == "1")
                acceso = true;
            if (ag == "1")
                agregar = true;
            if (ed == "1")
                editar = true;
            if (el == "1")
                eliminar = true;
            if (vis == "1")
                visualiar = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ( visualiar == true)
            {
                FrmAgregarUsuarios fa = new FrmAgregarUsuarios();
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso");
                toolStripMenuItem2.Enabled = false;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (visualiar == true)
            {
                FrmAgregarProducto fp = new FrmAgregarProducto(agregar, editar, eliminar);
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso");
                toolStripMenuItem4.Enabled = false;
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (visualiar == true)
            {
                FrmAgregarHerramienta fh = new FrmAgregarHerramienta(agregar, editar, eliminar);
                fh.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso");
                toolStripMenuItem5.Enabled = false; 
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmLog fl = new FrmLog();
            Hide();
            fl.ShowDialog();
           this.Close();
        }

        private void FrmPricipal_Load(object sender, EventArgs e)
        {

        }
    }
}
