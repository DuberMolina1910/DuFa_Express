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
    public partial class SolicitudesAnulacion : Form
    {
        public SolicitudesAnulacion()
        {
            InitializeComponent();
        }

        private void SolicitudesAnulacion_Load(object sender, EventArgs e)
        {
            dgvSolAnul();
        }
        private void dgvSolAnul()
        {
            UsuarioDAL_C envios = new UsuarioDAL_C();
            dgvSolicAnulacion.DataSource = envios.getTabEnviosEstadoSolAnulDGV();
        }
    }
}
