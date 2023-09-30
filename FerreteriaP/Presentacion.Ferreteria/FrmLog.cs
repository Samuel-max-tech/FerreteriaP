﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Ferreteria;

namespace Presentacion.Ferreteria
{
    public partial class FrmLog : Form
    {
        LogLogica log;
        public FrmLog()
        {
            InitializeComponent();
            log = new LogLogica();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (log.ValidarAcceso(txtUsuario.Text, txtContrasena.Text))
            {
                FrmPricipal p = new FrmPricipal();
                p.Show();
                Hide();
            }
            else
                MessageBox.Show("Error de credenciales");
        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios fa = new FrmAgregarUsuarios();
            fa.ShowDialog();
        }
    }
}