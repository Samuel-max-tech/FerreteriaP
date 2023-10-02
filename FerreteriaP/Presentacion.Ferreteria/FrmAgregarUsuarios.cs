using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio.Ferreteria;

namespace Presentacion.Ferreteria
{
    public partial class FrmAgregarUsuarios : Form
    {
        private UsuariosLogica _usuarioslogica;
        private string banderaGuardar = " ";
        private int idusuarios = 0;
        public FrmAgregarUsuarios()
        {
            InitializeComponent();
            _usuarioslogica = new UsuariosLogica();
        }

        private void FrmAgregarUsuarios_Load(object sender, EventArgs e)
        {
            ControlarBotones(true, false, true, true, true);
            ControlCuadros(false);
            LlenarUsuario();
        }
        private void ControlarBotones(Boolean nuevo, Boolean guardar, Boolean cancelar, Boolean cerrar, Boolean eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
            btnCerrar.Enabled = cerrar;
        }
        private void ControlCuadros(Boolean estado)
        {
            txtNombre.Enabled = estado;
            txtApellidoP.Enabled = estado;
            txtApellidoM.Enabled = estado;
            txtFenac.Enabled = estado;
            txtrfc.Enabled = estado;
            txtusuario.Enabled = estado;
            txtContrasena.Enabled = estado;
            cbxacceso.Enabled = estado;
            cbxagregar.Enabled = estado;
            cbxeditar.Enabled = estado;
            cbxeliminar.Enabled = estado;
            cbxvisualizar.Enabled = estado;
        }
        private void Volvervalorcbx(bool estado)
        {
            cbxacceso.Checked = estado;
            cbxagregar.Checked = estado;
            cbxeditar.Checked = estado;
            cbxeliminar.Checked = estado;
            cbxvisualizar.Checked = estado;
        }
        private void Activarvalorcbx(bool estado)
        {
            cbxacceso.Enabled = estado;
            cbxagregar.Enabled = estado;
            cbxeditar.Enabled = estado;
            cbxeliminar.Enabled = estado;
            cbxvisualizar.Enabled = estado;
        }
        private void LlenarUsuario()
        {
            DtgUsuarios.DataSource = _usuarioslogica.ObtenerUsuarios();
        }
        private void LimpiarTextBox()
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtFenac.Text = "";
            txtrfc.Text = "";
            txtusuario.Text = "";
            txtContrasena.Text = "";
        }
        private void GuardarUsuario()
        {
            Usuarios nuevousuario = new Usuarios();
            nuevousuario.Nombre = txtNombre.Text;
            nuevousuario.Apellidop = txtApellidoP.Text;
            nuevousuario.Apellidom = txtApellidoM.Text;
            nuevousuario.Fechanacimiento = txtFenac.Text;
            nuevousuario.Rfc=txtrfc.Text;
            nuevousuario.Usuario = txtusuario.Text;
            nuevousuario.Contrasena = txtContrasena.Text;
            nuevousuario.Acceso = cbxacceso.Checked;
            nuevousuario.Agregar = cbxagregar.Checked;
            nuevousuario.Editar = cbxeditar.Checked;
            nuevousuario.Eliminar = cbxeliminar.Checked;
            nuevousuario.Visualizar = cbxvisualizar.Checked;
            var validar = _usuarioslogica.ValidadUsuario(nuevousuario);
            if (validar.Item1)
            {
                _usuarioslogica.GuardarUsuario(nuevousuario);
                LlenarUsuario();
                LimpiarTextBox();
                ControlarBotones(true, false, false, true, true);
                ControlCuadros(false);
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModificarUsuario()
        {
            Usuarios nuevousuario = new Usuarios();
            nuevousuario.IdUsuario = idusuarios;
            nuevousuario.Nombre = txtNombre.Text;
            nuevousuario.Apellidop = txtApellidoP.Text;
            nuevousuario.Apellidom = txtApellidoM.Text;
            nuevousuario.Fechanacimiento = txtFenac.Text;
            nuevousuario.Rfc = txtrfc.Text;
            nuevousuario.Usuario = txtusuario.Text;
            nuevousuario.Contrasena = txtContrasena.Text;
            nuevousuario.Acceso=cbxacceso.Checked;
            nuevousuario.Agregar = cbxagregar.Checked;
            nuevousuario.Editar = cbxeditar.Checked;
            nuevousuario.Eliminar = cbxeliminar.Checked;
            nuevousuario.Visualizar = cbxvisualizar.Checked;
            var validar = _usuarioslogica.ValidadUsuario(nuevousuario);
            if (validar.Item1)
            {
                _usuarioslogica.ActualizarUsuarios(nuevousuario);
                LlenarUsuario();
                LimpiarTextBox();
                ControlarBotones(true, false, false, true, true);
                ControlCuadros(false);
                txtNombre.Focus();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a este Usuari@", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idusuarios = int.Parse(DtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
                _usuarioslogica.EliminarUsuarios(idusuarios);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtNombre.Focus();
            banderaGuardar = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar.Equals("Guardar"))
            {
                GuardarUsuario();
            }
            else if (banderaGuardar.Equals("Modificar"))
            {
                ModificarUsuario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarBotones(true, false, false, true, true);
            ControlCuadros(false);
            Volvervalorcbx(false);
            LimpiarTextBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarUsuario();
        }

        private void DtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            Activarvalorcbx(false);
            txtNombre.Focus();
            txtusuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtNombre.Text = DtgUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoP.Text = DtgUsuarios.CurrentRow.Cells["apellidop"].Value.ToString();
            txtApellidoM.Text = DtgUsuarios.CurrentRow.Cells["apellidom"].Value.ToString();
            txtFenac.Text = DtgUsuarios.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            txtrfc.Text = DtgUsuarios.CurrentRow.Cells["rfc"].Value.ToString();
            txtusuario.Text = DtgUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
            txtContrasena.Text = DtgUsuarios.CurrentRow.Cells["contrasena"].Value.ToString();
            idusuarios = int.Parse(DtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
            idusuarios = int.Parse(DtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
            cbxacceso.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["acceso"].Value.ToString());
            cbxagregar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["agregar"].Value.ToString());
            cbxeditar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["editar"].Value.ToString());
            cbxeliminar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["eliminar"].Value.ToString());
            cbxvisualizar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["visualizar"].Value.ToString());
            banderaGuardar = "Modificar";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }
        private void Buscar(string valor)
        {
            DtgUsuarios.DataSource = _usuarioslogica.BuscarUsuario(valor);
        }

        private void DtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            Activarvalorcbx(true);
            txtNombre.Focus();
            txtNombre.Text = DtgUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoP.Text = DtgUsuarios.CurrentRow.Cells["apellidop"].Value.ToString();
            txtApellidoM.Text = DtgUsuarios.CurrentRow.Cells["apellidom"].Value.ToString();
            txtFenac.Text = DtgUsuarios.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            txtrfc.Text = DtgUsuarios.CurrentRow.Cells["rfc"].Value.ToString();
            txtNombre.Enabled = false;
            txtApellidoP.Enabled= false;
            txtApellidoM.Enabled= false;
            txtFenac.Enabled= false;
            txtrfc.Enabled = false;
            txtusuario.Text = DtgUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
            txtContrasena.Text = "";
            idusuarios = int.Parse(DtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
            cbxacceso.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["acceso"].Value.ToString());
            cbxagregar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["agregar"].Value.ToString());
            cbxeditar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["editar"].Value.ToString());
            cbxeliminar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["eliminar"].Value.ToString());
            cbxvisualizar.Checked = bool.Parse(DtgUsuarios.CurrentRow.Cells["visualizar"].Value.ToString());
            banderaGuardar = "Modificar";
        }
    }
}
