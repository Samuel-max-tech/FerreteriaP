using Entidades;
using LogicaNegocio.Ferreteria;
using System;
using System.Collections.Concurrent;
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
    public partial class FrmAgregarPermisos : Form
    {
        PermisosLogica permisosLogica;
        public FrmAgregarPermisos()
        {
            InitializeComponent();
            permisosLogica = new PermisosLogica();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPuntos();
        }
        private void LimpiarPuntos()
        {
            cbxacceso.Checked = false;
            cbxagregar.Checked = false;
            cbxeditar.Checked = false;
            cbxeliminar.Checked = false;
            cbxvisualizar.Checked = false;
        }

        private void FrmAgregarPermisos_Load(object sender, EventArgs e)
        {

        }
    }
}