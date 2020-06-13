﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuFa_express
{
    public partial class PerfilAdminSuc : Form
    {
        public PerfilAdminSuc()
        {
            InitializeComponent();
        }

        private void BtnRgstUsrAdmSuc_Click(object sender, EventArgs e)
        {
            RegUsers reguser = new RegUsers();
            reguser.ShowDialog();
            
        }

        private void lblCerrarSesión_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Index index = new Index();
                index.Show();
                this.Close();
            }            
        }

        private void lblRgstUsrAdmSuc_Click(object sender, EventArgs e)
        {
            AbrirSubForms(new RegUsers());
        }

        private void AbrirSubForms(object SubForms)
        {
            if (this.pnlShowSubForm.Controls.Count > 0)
                this.pnlShowSubForm.Controls.RemoveAt(0);
            {
                Form frm = SubForms as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.pnlShowSubForm.Controls.Add(frm);
                this.pnlShowSubForm.Tag = frm;
                frm.Show();
            }
        }

        private void lblRegCiudad_Click(object sender, EventArgs e)
        {
            AbrirSubForms(new RegCiudad());
        }
    }
}