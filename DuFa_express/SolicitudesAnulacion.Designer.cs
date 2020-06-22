namespace DuFa_express
{
    partial class SolicitudesAnulacion
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
            this.dgvSolicAnulacion = new System.Windows.Forms.DataGridView();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnAnularEnvio = new System.Windows.Forms.Button();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtNumGuia = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicAnulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicAnulacion
            // 
            this.dgvSolicAnulacion.AllowUserToAddRows = false;
            this.dgvSolicAnulacion.AllowUserToDeleteRows = false;
            this.dgvSolicAnulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolicAnulacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSolicAnulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicAnulacion.Location = new System.Drawing.Point(4, 127);
            this.dgvSolicAnulacion.Name = "dgvSolicAnulacion";
            this.dgvSolicAnulacion.RowHeadersVisible = false;
            this.dgvSolicAnulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicAnulacion.Size = new System.Drawing.Size(676, 319);
            this.dgvSolicAnulacion.TabIndex = 1;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsgError.Location = new System.Drawing.Point(135, 101);
            this.lblMsgError.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(34, 17);
            this.lblMsgError.TabIndex = 89;
            this.lblMsgError.Text = "Error";
            this.lblMsgError.Visible = false;
            // 
            // btnAnularEnvio
            // 
            this.btnAnularEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularEnvio.Location = new System.Drawing.Point(406, 64);
            this.btnAnularEnvio.Name = "btnAnularEnvio";
            this.btnAnularEnvio.Size = new System.Drawing.Size(100, 25);
            this.btnAnularEnvio.TabIndex = 88;
            this.btnAnularEnvio.Text = "ANULAR";
            this.btnAnularEnvio.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(135, 65);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(190, 24);
            this.cmbEstadoEnvio.TabIndex = 87;
            this.cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
            // 
            // txtNumGuia
            // 
            this.txtNumGuia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuia.Location = new System.Drawing.Point(135, 24);
            this.txtNumGuia.Name = "txtNumGuia";
            this.txtNumGuia.Size = new System.Drawing.Size(190, 23);
            this.txtNumGuia.TabIndex = 86;
            this.txtNumGuia.Text = "*N° GUIA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(406, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // SolicitudesAnulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.btnAnularEnvio);
            this.Controls.Add(this.cmbEstadoEnvio);
            this.Controls.Add(this.txtNumGuia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvSolicAnulacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudesAnulacion";
            this.Text = "SolicitudesAnulacion";
            this.Load += new System.EventHandler(this.SolicitudesAnulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicAnulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicAnulacion;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.Button btnAnularEnvio;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtNumGuia;
        private System.Windows.Forms.Button btnBuscar;
    }
}