namespace DuFa_express
{
    partial class GesEnvios
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
            this.dgvGesEnvios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumGuia = new System.Windows.Forms.TextBox();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.btnAnularEnvio = new System.Windows.Forms.Button();
            this.btnSolAnulacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGesEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGesEnvios
            // 
            this.dgvGesEnvios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGesEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGesEnvios.Location = new System.Drawing.Point(12, 159);
            this.dgvGesEnvios.Name = "dgvGesEnvios";
            this.dgvGesEnvios.Size = new System.Drawing.Size(676, 319);
            this.dgvGesEnvios.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(248, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumGuia
            // 
            this.txtNumGuia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuia.Location = new System.Drawing.Point(12, 33);
            this.txtNumGuia.Name = "txtNumGuia";
            this.txtNumGuia.Size = new System.Drawing.Size(190, 23);
            this.txtNumGuia.TabIndex = 3;
            this.txtNumGuia.Text = "*N° GUIA";
            this.txtNumGuia.Enter += new System.EventHandler(this.txtNumGuia_Enter);
            this.txtNumGuia.Leave += new System.EventHandler(this.txtNumGuia_Leave);
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(12, 74);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(190, 24);
            this.cmbEstadoEnvio.TabIndex = 81;
            this.cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
            // 
            // btnAnularEnvio
            // 
            this.btnAnularEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularEnvio.Location = new System.Drawing.Point(248, 74);
            this.btnAnularEnvio.Name = "btnAnularEnvio";
            this.btnAnularEnvio.Size = new System.Drawing.Size(100, 25);
            this.btnAnularEnvio.TabIndex = 82;
            this.btnAnularEnvio.Text = "ANULAR";
            this.btnAnularEnvio.UseVisualStyleBackColor = true;
            // 
            // btnSolAnulacion
            // 
            this.btnSolAnulacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolAnulacion.Location = new System.Drawing.Point(389, 33);
            this.btnSolAnulacion.Name = "btnSolAnulacion";
            this.btnSolAnulacion.Size = new System.Drawing.Size(166, 25);
            this.btnSolAnulacion.TabIndex = 83;
            this.btnSolAnulacion.Text = "SOLICITAR ANULACION";
            this.btnSolAnulacion.UseVisualStyleBackColor = true;
            // 
            // GesEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.btnSolAnulacion);
            this.Controls.Add(this.btnAnularEnvio);
            this.Controls.Add(this.cmbEstadoEnvio);
            this.Controls.Add(this.txtNumGuia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvGesEnvios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesEnvios";
            this.Text = "GesEnvios";
            this.Load += new System.EventHandler(this.GesEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGesEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGesEnvios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumGuia;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.Button btnAnularEnvio;
        private System.Windows.Forms.Button btnSolAnulacion;
    }
}