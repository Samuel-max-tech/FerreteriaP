namespace Presentacion.Ferreteria
{
    partial class FrmAgregarPermisos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxacceso = new System.Windows.Forms.CheckBox();
            this.cbxagregar = new System.Windows.Forms.CheckBox();
            this.cbxeditar = new System.Windows.Forms.CheckBox();
            this.cbxeliminar = new System.Windows.Forms.CheckBox();
            this.cbxvisualizar = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::Presentacion.Ferreteria.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::Presentacion.Ferreteria.Properties.Resources.cerrar;
            this.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrar.Location = new System.Drawing.Point(597, 28);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxacceso
            // 
            this.cbxacceso.AutoSize = true;
            this.cbxacceso.Location = new System.Drawing.Point(62, 70);
            this.cbxacceso.Name = "cbxacceso";
            this.cbxacceso.Size = new System.Drawing.Size(96, 29);
            this.cbxacceso.TabIndex = 1;
            this.cbxacceso.Text = "Acceso";
            this.cbxacceso.UseVisualStyleBackColor = true;
            // 
            // cbxagregar
            // 
            this.cbxagregar.AutoSize = true;
            this.cbxagregar.Location = new System.Drawing.Point(180, 70);
            this.cbxagregar.Name = "cbxagregar";
            this.cbxagregar.Size = new System.Drawing.Size(104, 29);
            this.cbxagregar.TabIndex = 2;
            this.cbxagregar.Text = "Agregar";
            this.cbxagregar.UseVisualStyleBackColor = true;
            // 
            // cbxeditar
            // 
            this.cbxeditar.AutoSize = true;
            this.cbxeditar.Location = new System.Drawing.Point(62, 124);
            this.cbxeditar.Name = "cbxeditar";
            this.cbxeditar.Size = new System.Drawing.Size(83, 29);
            this.cbxeditar.TabIndex = 3;
            this.cbxeditar.Text = "Editar";
            this.cbxeditar.UseVisualStyleBackColor = true;
            // 
            // cbxeliminar
            // 
            this.cbxeliminar.AutoSize = true;
            this.cbxeliminar.Location = new System.Drawing.Point(180, 124);
            this.cbxeliminar.Name = "cbxeliminar";
            this.cbxeliminar.Size = new System.Drawing.Size(104, 29);
            this.cbxeliminar.TabIndex = 4;
            this.cbxeliminar.Text = "Eliminar";
            this.cbxeliminar.UseVisualStyleBackColor = true;
            // 
            // cbxvisualizar
            // 
            this.cbxvisualizar.AutoSize = true;
            this.cbxvisualizar.Location = new System.Drawing.Point(317, 70);
            this.cbxvisualizar.Name = "cbxvisualizar";
            this.cbxvisualizar.Size = new System.Drawing.Size(118, 29);
            this.cbxvisualizar.TabIndex = 5;
            this.cbxvisualizar.Text = "Visualizar";
            this.cbxvisualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_guardar_30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(62, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Presentacion.Ferreteria.Properties.Resources.icons8_cancelar_30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(317, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUsuarios.Location = new System.Drawing.Point(62, 199);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(222, 33);
            this.cmbUsuarios.TabIndex = 6;
            // 
            // FrmAgregarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::Presentacion.Ferreteria.Properties.Resources.Business_Card_Brackets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 379);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxvisualizar);
            this.Controls.Add(this.cbxeliminar);
            this.Controls.Add(this.cbxeditar);
            this.Controls.Add(this.cbxagregar);
            this.Controls.Add(this.cbxacceso);
            this.Controls.Add(this.btnCerrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmAgregarPermisos";
            this.Text = "FrmAgregarPermisos";
            this.Load += new System.EventHandler(this.FrmAgregarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox cbxacceso;
        private System.Windows.Forms.CheckBox cbxagregar;
        private System.Windows.Forms.CheckBox cbxeditar;
        private System.Windows.Forms.CheckBox cbxeliminar;
        private System.Windows.Forms.CheckBox cbxvisualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}