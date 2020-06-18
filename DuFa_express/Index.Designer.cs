namespace DuFa_express
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.PnlDf = new System.Windows.Forms.Panel();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblAcceder = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.BtnIniciarSesClient = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtNumID = new System.Windows.Forms.TextBox();
            this.cmbTipoPer = new System.Windows.Forms.ComboBox();
            this.PnlDf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDf
            // 
            this.PnlDf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PnlDf.Controls.Add(this.picBxLogo);
            this.PnlDf.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlDf.Location = new System.Drawing.Point(0, 0);
            this.PnlDf.Name = "PnlDf";
            this.PnlDf.Size = new System.Drawing.Size(220, 328);
            this.PnlDf.TabIndex = 6;
            // 
            // picBxLogo
            // 
            this.picBxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBxLogo.Image")));
            this.picBxLogo.Location = new System.Drawing.Point(5, 45);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(210, 230);
            this.picBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLogo.TabIndex = 0;
            this.picBxLogo.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.Location = new System.Drawing.Point(405, 283);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 33);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblAcceder
            // 
            this.lblAcceder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceder.Location = new System.Drawing.Point(226, 14);
            this.lblAcceder.Name = "lblAcceder";
            this.lblAcceder.Size = new System.Drawing.Size(192, 30);
            this.lblAcceder.TabIndex = 3;
            this.lblAcceder.Text = "ACCEDER COMO";
            this.lblAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegistro
            // 
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(295, 232);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(170, 30);
            this.lblRegistro.TabIndex = 4;
            this.lblRegistro.Text = "REGISTRARSE";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsgError.Location = new System.Drawing.Point(251, 155);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(34, 17);
            this.lblMsgError.TabIndex = 20;
            this.lblMsgError.Text = "Error";
            this.lblMsgError.Visible = false;
            // 
            // BtnIniciarSesClient
            // 
            this.BtnIniciarSesClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnIniciarSesClient.Location = new System.Drawing.Point(299, 177);
            this.BtnIniciarSesClient.Name = "BtnIniciarSesClient";
            this.BtnIniciarSesClient.Size = new System.Drawing.Size(119, 41);
            this.BtnIniciarSesClient.TabIndex = 18;
            this.BtnIniciarSesClient.Text = "INICIAR SESIÓN";
            this.BtnIniciarSesClient.UseVisualStyleBackColor = true;
            this.BtnIniciarSesClient.Click += new System.EventHandler(this.BtnIniciarSesClient_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.TxtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TxtContrasena.Location = new System.Drawing.Point(251, 126);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(241, 26);
            this.TxtContrasena.TabIndex = 17;
            this.TxtContrasena.Text = "*CONTRASEÑA";
            this.TxtContrasena.Enter += new System.EventHandler(this.TxtContrasena_Enter);
            this.TxtContrasena.Leave += new System.EventHandler(this.TxtContrasena_Leave);
            // 
            // TxtNumID
            // 
            this.TxtNumID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.TxtNumID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TxtNumID.Location = new System.Drawing.Point(251, 87);
            this.TxtNumID.Name = "TxtNumID";
            this.TxtNumID.Size = new System.Drawing.Size(241, 26);
            this.TxtNumID.TabIndex = 16;
            this.TxtNumID.Text = "*N° IDENTIFICACIÓN";
            this.TxtNumID.Enter += new System.EventHandler(this.TxtNumID_Enter);
            this.TxtNumID.Leave += new System.EventHandler(this.TxtNumID_Leave);
            // 
            // cmbTipoPer
            // 
            this.cmbTipoPer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipoPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cmbTipoPer.FormattingEnabled = true;
            this.cmbTipoPer.Location = new System.Drawing.Point(251, 50);
            this.cmbTipoPer.Name = "cmbTipoPer";
            this.cmbTipoPer.Size = new System.Drawing.Size(241, 26);
            this.cmbTipoPer.TabIndex = 21;
            this.cmbTipoPer.Text = "*TIPO DE USUARIO";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.cmbTipoPer);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.BtnIniciarSesClient);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtNumID);
            this.Controls.Add(this.PnlDf);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblAcceder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceder";
            this.Load += new System.EventHandler(this.Index_Load);
            this.PnlDf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlDf;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblAcceder;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.Button BtnIniciarSesClient;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtNumID;
        private System.Windows.Forms.ComboBox cmbTipoPer;
    }
}

