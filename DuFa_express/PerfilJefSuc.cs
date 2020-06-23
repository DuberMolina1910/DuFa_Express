using System;
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
    public partial class PerfilJefSuc : Form
    {
        public PerfilJefSuc()
        {
            InitializeComponent();
        }

        private void PerfilJefSuc_Load(object sender, EventArgs e)
        {
            InfoUsuarios();
        }

        private void InfoUsuarios()
        {
            lblNombre.Text = Cache.NomUsu;
            lblNomTipoPer.Text = Cache.NomTipoPer;
        }

        private void AbrirSubForms(object SubForms)
        {
            if (this.PnlPerfilJefSuc2.Controls.Count > 0)
                this.PnlPerfilJefSuc2.Controls.RemoveAt(0);
            {
                Form frm = SubForms as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.PnlPerfilJefSuc2.Controls.Add(frm);
                this.PnlPerfilJefSuc2.Tag = frm;
                frm.Show();
            }
        }
        private void lblPerJefSucCrearEnv_Click(object sender, EventArgs e)
        {
            //Nuevo Envio
            AbrirSubForms(new RegEnvio());
        }
        private void LblGesEnvPerJefSuc_Click(object sender, EventArgs e)
        {
            //GestionarEnvios
            AbrirSubForms(new GesEnvios());
        }
        private void lblRegUserPerJerSuc_Click_1(object sender, EventArgs e)
        {
            //Registrar Usuarios
            AbrirSubForms(new RegUsers());
        }
        private void LblSolAnulRegJefSuc_Click(object sender, EventArgs e)
        {
            //Solicitudes de Anulacion
            AbrirSubForms(new SolicitudesAnulacion());
        }
        private void LblRepSucPerJefSuc_Click(object sender, EventArgs e)
        {
            //Reporte Sucursal
        }
        private void lblCerrarSesión_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Index index = new Index();
                index.Show();
                this.Close();
            }
        }


    }
}
