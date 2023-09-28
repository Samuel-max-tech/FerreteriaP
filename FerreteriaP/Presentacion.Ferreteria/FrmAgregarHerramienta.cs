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
    public partial class FrmAgregarHerramienta : Form
    {
        private HerramientasLogica _herramientaslogica;
        private string banderaGuardar = " ";
        private int codigoherramientas = 0;
        public FrmAgregarHerramienta()
        {
            InitializeComponent();
            _herramientaslogica = new HerramientasLogica();
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
            txtCH.Enabled = estado;
            txtNombre.Enabled = estado;
            txtMarca.Enabled = estado;
            txtMedida.Enabled = estado;
            txtDescripcion.Enabled = estado;
        }
        private void LlenarHerramienta()
        {
            DtgHerramientas.DataSource = _herramientaslogica.ObtenerHerramientas();
        }
        private void LimpiarTextBox()
        {
            txtCH.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtMedida.Text = "";
            txtDescripcion.Text = "";
        }
        private void GuardarProducto()
        {
            Herramientas nuevaherramienta = new Herramientas();
            nuevaherramienta.CodigoHerramienta = int.Parse(txtCH.Text);
            nuevaherramienta.NombreH = txtNombre.Text;
            nuevaherramienta.MarcaH = txtMarca.Text;
            nuevaherramienta.Medida = txtMedida.Text;
            nuevaherramienta.DescripciónH = txtDescripcion.Text;

            var validar = _herramientaslogica.ValidarHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _herramientaslogica.GuardarHerramienta(nuevaherramienta);
                LlenarHerramienta();
                LimpiarTextBox();
                ControlarBotones(true, false, false, true, true);
                ControlCuadros(false);
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a este Usuari@", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var codigoherramientas = int.Parse(DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString());
                _herramientaslogica.EliminarHerramienta(codigoherramientas);
            }
        }
        private void ModificarProducto()
        {
            Herramientas nuevaherramienta = new Herramientas();
            nuevaherramienta.CodigoHerramienta = int.Parse(txtCH.Text);
            nuevaherramienta.NombreH = txtNombre.Text;
            nuevaherramienta.MarcaH = txtMarca.Text;
            nuevaherramienta.Medida = txtMedida.Text;
            nuevaherramienta.DescripciónH = txtDescripcion.Text;

            var validar = _herramientaslogica.ValidarHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _herramientaslogica.ActualizarProducto(nuevaherramienta);
                LlenarHerramienta();
                LimpiarTextBox();
                ControlarBotones(true, false, false, true, true);
                ControlCuadros(false);
                txtCH.Focus();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BuscarHerramientas(int valor)
        {
            DtgHerramientas.DataSource = _herramientaslogica.BuscarHerramienta(valor);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtCH.Focus();
            banderaGuardar = "Guardar";
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
        private void DtgHerramientas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtCH.Focus();
            txtCH.Text = DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString();
            txtNombre.Text = DtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
            txtMedida.Text = DtgHerramientas.CurrentRow.Cells["medida"].Value.ToString();
            txtMarca.Text = DtgHerramientas.CurrentRow.Cells["marca"].Value.ToString();
            txtDescripcion.Text = DtgHerramientas.CurrentRow.Cells["descripción"].Value.ToString();
            banderaGuardar = "Modificar";
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtCH.Focus();
            banderaGuardar = "Guardar";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarBotones(true, false, false, true, true);
            ControlCuadros(false);
            LimpiarTextBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarHerramienta();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgregarHerramienta_Load(object sender, EventArgs e)
        {
            ControlarBotones(true, false, false, true, true);
            ControlCuadros(false);
            LlenarHerramienta();
        }

        private void DtgHerramientas_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtCH.Focus();
            txtCH.Text = DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString();
            txtNombre.Text = DtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
            txtMedida.Text = DtgHerramientas.CurrentRow.Cells["medida"].Value.ToString();
            txtMarca.Text = DtgHerramientas.CurrentRow.Cells["marca"].Value.ToString();
            txtDescripcion.Text = DtgHerramientas.CurrentRow.Cells["descripción"].Value.ToString();
            banderaGuardar = "Modificar";
        }
    }
}
