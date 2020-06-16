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
    public partial class PerfilGesSuc : Form
    {
        public PerfilGesSuc()
        {
            InitializeComponent();
        }

        private void PerfilGesSuc_Load(object sender, EventArgs e)
        {
            InfoUsuarios();
        }
        private void InfoUsuarios()
        {
            lblNombre.Text = Cache.NomUsu;
            lblNomTipoPer.Text = Cache.NomTipoPer;
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
