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
        public bool agregar;
        public bool editar;
        public bool eliminar;
        private HerramientasLogica _herramientaslogica;
        private string banderaGuardar = " ";
        private int codigoherramientas = 0 ;
        public FrmAgregarHerramienta(bool ag, bool ed, bool el)
        {
            InitializeComponent();
            _herramientaslogica = new HerramientasLogica();
            ControlarBotones(agregar = ag, editar = ed, eliminar = el);
        }
        private void ControlarBotones(Boolean escribir, Boolean eliminar, Boolean actualizar)
        {
            btnNuevo.Enabled = escribir;
            btnGuardar.Enabled = actualizar;
            btnEliminar.Enabled = eliminar;
            btnCancelar.Enabled = false;
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
        private void GuardarHerramienta()
        {
            Herramientas nuevaherramienta = new Herramientas();
            nuevaherramienta.CodigoHerramienta = int.Parse(txtCH.Text);
            nuevaherramienta.Nombreh = txtNombre.Text;
            nuevaherramienta.Marcah = txtMarca.Text;
            nuevaherramienta.Medidah = txtMedida.Text;
            nuevaherramienta.Descripcionh = txtDescripcion.Text;

            var validar = _herramientaslogica.ValidarHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _herramientaslogica.GuardarHerramienta(nuevaherramienta);
                LlenarHerramienta();
                LimpiarTextBox();
                ControlCuadros(false);
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModificarHerramienta()
        {
            Herramientas nuevaherramienta = new Herramientas();
            nuevaherramienta.CodigoHerramienta = int.Parse(txtCH.Text);
            nuevaherramienta.Nombreh = txtNombre.Text;
            nuevaherramienta.Medidah = txtMedida.Text;
            nuevaherramienta.Marcah = txtMarca.Text;
            nuevaherramienta.Descripcionh = txtDescripcion.Text;

            var validar = _herramientaslogica.ValidarHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _herramientaslogica.ActualizarHerramienta(nuevaherramienta);
                LlenarHerramienta();
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
                var codigoherramientas = int.Parse(DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString());
                _herramientaslogica.EliminarHerramienta(codigoherramientas);
            }
        }
        private void Buscar(string valor)
        {
            DtgHerramientas.DataSource = _herramientaslogica.BuscarHerramienta(valor);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlCuadros(false);
            LimpiarTextBox();
            ControlarBotones(agregar, editar, eliminar);
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
            ControlCuadros(false);
            LlenarHerramienta();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar.Equals("Guardar"))
            {
                GuardarHerramienta();
            }
            else if (banderaGuardar.Equals("Modificar"))
            {
                ModificarHerramienta();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControlCuadros(true);
            txtCH.Focus();
            banderaGuardar = "Guardar";
        }

        private void DtgHerramientas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ControlCuadros(true);
            txtCH.Focus();
            txtCH.Text = DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString();
            codigoherramientas = int.Parse(DtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString());
            txtNombre.Text = DtgHerramientas.CurrentRow.Cells["nombreh"].Value.ToString();
            txtMedida.Text = DtgHerramientas.CurrentRow.Cells["medidah"].Value.ToString();
            txtMarca.Text = DtgHerramientas.CurrentRow.Cells["marcah"].Value.ToString();
            txtDescripcion.Text = DtgHerramientas.CurrentRow.Cells["descripcionh"].Value.ToString();
            banderaGuardar = "Modificar";
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
