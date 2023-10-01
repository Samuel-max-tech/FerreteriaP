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
            if (cmbUsuarios.SelectedItem != null)
            {
                Usuarios usuario = (Usuarios)cmbUsuarios.SelectedItem;
                Permisos permisos = new Permisos
                {
                    Acceso = cbxacceso.Checked,
                    Agregar = cbxagregar.Checked,
                    Editar = cbxeditar.Checked,
                    Eliminar = cbxeliminar.Checked,
                    Visualizar = cbxvisualizar.Checked,
                    Fkidusuario = usuario.IdUsuario
                };

                permisosLogica.ActualizarPermisos(permisos);

                MessageBox.Show("Permisos guardados correctamente.");
            }
            else
            {
                MessageBox.Show("Selecciona un usuario.");
            }
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

        private void CargarUsuarios()
        {
            List<string> nombresUsuarios = permisosLogica.ObtenerNombresUsuariosConPermisos();

            foreach (string nombreUsuario in nombresUsuarios)
            {
                cmbUsuarios.Items.Add(nombreUsuario);
            }
        }

        private void FrmAgregarPermisos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}