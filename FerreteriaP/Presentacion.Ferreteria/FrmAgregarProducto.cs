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
using Entidades;

namespace Presentacion.Ferreteria
{
    public partial class FrmAgregarProducto : Form
    {
        public bool agregar;
        public bool editar;
        public bool eliminar;
        private ProductosLogica  _productoslogica;
        private string banderaGuardar = " ";
        private string codigobarras = "";
        public FrmAgregarProducto( bool ag, bool ed, bool el)
        {
            InitializeComponent();
            _productoslogica = new ProductosLogica();
            ControlarBotones(agregar=ag,editar=ed,eliminar=el);
        }

        private void FrmAgregarProductos(object sender, EventArgs e)
        {
            ControlCuadros(false);
            LlenarProducto();
        }
        private void ControlarBotones(Boolean escribir, Boolean eliminar, Boolean actualizar)
        {
            btnNuevo.Enabled = escribir;
            btnEliminar.Enabled = eliminar;
            btnGuardar.Enabled = actualizar;
            btnCancelar .Enabled = false;
        }
        private void ControlCuadros(Boolean estado)
        {
            txtCB.Enabled = estado;
            txtNombrep.Enabled = estado;
            txtDescripcionp.Enabled = estado;
            txtMarcap.Enabled = estado;
        }
        private void LlenarProducto()
        {
            DtgProductos.DataSource = _productoslogica.ObtenerProducto();
        }
        private void LimpiarTextBox()
        {
            txtCB.Text = "";
            txtNombrep.Text = "";
            txtDescripcionp.Text = "";
            txtMarcap.Text = "";
        }
        private void GuardarProducto()
        {
            Productos nuevoproducto = new Productos();
            nuevoproducto.CodigoBarras=int.Parse(txtCB.Text);
            nuevoproducto.Nombrep = txtNombrep.Text;
            nuevoproducto.Descripcionp = txtDescripcionp.Text;
            nuevoproducto.Marcap = txtMarcap.Text;
            var validar = _productoslogica.ValidarProducto(nuevoproducto);
            if (validar.Item1)
            {
                _productoslogica.GuardarProducto(nuevoproducto);
                LlenarProducto();
                LimpiarTextBox();
                ControlCuadros(false);
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a este Usuari@", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var codigobarras = int.Parse(DtgProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString());
                _productoslogica.EliminarProducto(codigobarras);
            }
        }
        private void ModificarProducto()
        {
            Productos nuevoproducto = new Productos();
            nuevoproducto.CodigoBarras = int.Parse(txtCB.Text);
            nuevoproducto.Nombrep = txtNombrep.Text;
            nuevoproducto.Descripcionp = txtDescripcionp.Text;
            nuevoproducto.Marcap = txtMarcap.Text;

            var validar = _productoslogica.ValidarProducto(nuevoproducto);
            if (validar.Item1)
            {
                _productoslogica.ActualizarProducto(nuevoproducto);
                LlenarProducto();
                LimpiarTextBox();
                ControlCuadros(false);
                txtCB.Focus();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Buscar(string valor)
        {
            DtgProductos.DataSource = _productoslogica.BuscarProducto(valor);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlCuadros(false);
            LimpiarTextBox();
            ControlarBotones(agregar, editar, eliminar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar.Equals("Guardar"))
            {
                GuardarProducto();
            }
            else if (banderaGuardar.Equals("Modificar"))
            {
                ModificarProducto();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlCuadros(true);
            btnCancelar.Enabled = true;
            txtCB.Focus();
            banderaGuardar = "Guardar";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            ControlCuadros(false);
            LlenarProducto();
        }

        private void DtgProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ControlCuadros(true);
            txtCB.Focus();
            txtCB.Text = DtgProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString();
            txtNombrep.Text = DtgProductos.CurrentRow.Cells["nombrep"].Value.ToString();
            txtDescripcionp.Text = DtgProductos.CurrentRow.Cells["descripcionp"].Value.ToString();
            txtMarcap.Text = DtgProductos.CurrentRow.Cells["marcap"].Value.ToString();
            codigobarras = DtgProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString();
            banderaGuardar = "Modificar";
        }
    }
}
