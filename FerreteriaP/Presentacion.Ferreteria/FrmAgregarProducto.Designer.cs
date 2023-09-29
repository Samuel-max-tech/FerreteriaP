namespace Presentacion.Ferreteria
{
    partial class FrmAgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarcap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrep = new System.Windows.Forms.TextBox();
            this.txtDescripcionp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(100, 291);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(577, 33);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Buscar:";
            // 
            // DtgProductos
            // 
            this.DtgProductos.AllowUserToAddRows = false;
            this.DtgProductos.BackgroundColor = System.Drawing.Color.White;
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Location = new System.Drawing.Point(23, 346);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.RowHeadersWidth = 62;
            this.DtgProductos.Size = new System.Drawing.Size(655, 231);
            this.DtgProductos.TabIndex = 69;
            this.DtgProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgProductos_CellMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(18, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(659, 12);
            this.label6.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(316, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 30);
            this.label4.TabIndex = 67;
            this.label4.Text = "Marca";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMarcap
            // 
            this.txtMarcap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcap.Location = new System.Drawing.Point(321, 188);
            this.txtMarcap.Name = "txtMarcap";
            this.txtMarcap.Size = new System.Drawing.Size(356, 33);
            this.txtMarcap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 65;
            this.label2.Text = "Descripción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombrep
            // 
            this.txtNombrep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrep.Location = new System.Drawing.Point(12, 114);
            this.txtNombrep.Name = "txtNombrep";
            this.txtNombrep.Size = new System.Drawing.Size(250, 33);
            this.txtNombrep.TabIndex = 2;
            // 
            // txtDescripcionp
            // 
            this.txtDescripcionp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionp.Location = new System.Drawing.Point(14, 188);
            this.txtDescripcionp.Name = "txtDescripcionp";
            this.txtDescripcionp.Size = new System.Drawing.Size(250, 33);
            this.txtDescripcionp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCB
            // 
            this.txtCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCB.Location = new System.Drawing.Point(12, 45);
            this.txtCB.Name = "txtCB";
            this.txtCB.Size = new System.Drawing.Size(665, 33);
            this.txtCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 30);
            this.label1.TabIndex = 63;
            this.label1.Text = "Codigo de Barras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_salida_30;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(560, 583);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 40);
            this.btnCerrar.TabIndex = 75;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_eliminar_30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(416, 583);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 40);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_cancelar_30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(279, 583);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 40);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_guardar_30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(149, 583);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 40);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_añadir_30;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(23, 583);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 40);
            this.btnNuevo.TabIndex = 71;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(689, 635);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtgProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarcap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombrep);
            this.Controls.Add(this.txtDescripcionp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarcap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrep;
        private System.Windows.Forms.TextBox txtDescripcionp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCB;
        private System.Windows.Forms.Label label1;
    }
}