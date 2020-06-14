namespace DuFa_express
{
    partial class RegSuc
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
            this.lblRegCiudad = new System.Windows.Forms.Label();
            this.txtRegSuc = new System.Windows.Forms.TextBox();
            this.CmbBxSelecCiudRegSuc = new System.Windows.Forms.ComboBox();
            this.BtnRegSuc = new System.Windows.Forms.Button();
            this.DtGrdVwTabSuc = new System.Windows.Forms.DataGridView();
            this.BtnDescSuc = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblMsgErrorSuc = new System.Windows.Forms.Label();
            this.BtnReactivarSuc = new System.Windows.Forms.Button();
            this.BtnRfrsDtGrdVwRegSuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwTabSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegCiudad
            // 
            this.lblRegCiudad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCiudad.Location = new System.Drawing.Point(0, 0);
            this.lblRegCiudad.Name = "lblRegCiudad";
            this.lblRegCiudad.Size = new System.Drawing.Size(518, 100);
            this.lblRegCiudad.TabIndex = 1;
            this.lblRegCiudad.Text = "REGISTRO DE  SUCURSAL";
            this.lblRegCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegSuc
            // 
            this.txtRegSuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegSuc.Location = new System.Drawing.Point(50, 146);
            this.txtRegSuc.Name = "txtRegSuc";
            this.txtRegSuc.Size = new System.Drawing.Size(264, 23);
            this.txtRegSuc.TabIndex = 3;
            this.txtRegSuc.Text = "NOMBRE DE LA SUCURSAL";
            this.txtRegSuc.Enter += new System.EventHandler(this.txtRegSuc_Enter);
            this.txtRegSuc.Leave += new System.EventHandler(this.txtRegCiudad_Leave);
            // 
            // CmbBxSelecCiudRegSuc
            // 
            this.CmbBxSelecCiudRegSuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbBxSelecCiudRegSuc.FormattingEnabled = true;
            this.CmbBxSelecCiudRegSuc.Location = new System.Drawing.Point(50, 116);
            this.CmbBxSelecCiudRegSuc.Name = "CmbBxSelecCiudRegSuc";
            this.CmbBxSelecCiudRegSuc.Size = new System.Drawing.Size(264, 24);
            this.CmbBxSelecCiudRegSuc.TabIndex = 4;
            this.CmbBxSelecCiudRegSuc.Text = "SELECCIONE CIUDAD";
            // 
            // BtnRegSuc
            // 
            this.BtnRegSuc.Location = new System.Drawing.Point(335, 130);
            this.BtnRegSuc.Name = "BtnRegSuc";
            this.BtnRegSuc.Size = new System.Drawing.Size(108, 39);
            this.BtnRegSuc.TabIndex = 5;
            this.BtnRegSuc.Text = "Agregar Sucursal";
            this.BtnRegSuc.UseVisualStyleBackColor = true;
            this.BtnRegSuc.Click += new System.EventHandler(this.BtnRegSuc_Click);
            // 
            // DtGrdVwTabSuc
            // 
            this.DtGrdVwTabSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwTabSuc.Location = new System.Drawing.Point(50, 204);
            this.DtGrdVwTabSuc.Name = "DtGrdVwTabSuc";
            this.DtGrdVwTabSuc.Size = new System.Drawing.Size(344, 139);
            this.DtGrdVwTabSuc.TabIndex = 6;
            // 
            // BtnDescSuc
            // 
            this.BtnDescSuc.Location = new System.Drawing.Point(398, 252);
            this.BtnDescSuc.Name = "BtnDescSuc";
            this.BtnDescSuc.Size = new System.Drawing.Size(108, 42);
            this.BtnDescSuc.TabIndex = 7;
            this.BtnDescSuc.Text = "Deshabilitar Sucursal";
            this.BtnDescSuc.UseVisualStyleBackColor = true;
            this.BtnDescSuc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(38, 364);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 24);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblMsgErrorSuc
            // 
            this.lblMsgErrorSuc.AutoSize = true;
            this.lblMsgErrorSuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgErrorSuc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsgErrorSuc.Location = new System.Drawing.Point(47, 175);
            this.lblMsgErrorSuc.Name = "lblMsgErrorSuc";
            this.lblMsgErrorSuc.Size = new System.Drawing.Size(34, 17);
            this.lblMsgErrorSuc.TabIndex = 17;
            this.lblMsgErrorSuc.Text = "Error";
            this.lblMsgErrorSuc.Visible = false;
            this.lblMsgErrorSuc.Click += new System.EventHandler(this.lblMsgError_Click);
            // 
            // BtnReactivarSuc
            // 
            this.BtnReactivarSuc.Location = new System.Drawing.Point(398, 204);
            this.BtnReactivarSuc.Name = "BtnReactivarSuc";
            this.BtnReactivarSuc.Size = new System.Drawing.Size(108, 42);
            this.BtnReactivarSuc.TabIndex = 18;
            this.BtnReactivarSuc.Text = "Habilitar Sucursal";
            this.BtnReactivarSuc.UseVisualStyleBackColor = true;
            this.BtnReactivarSuc.Click += new System.EventHandler(this.BtnReactivarSuc_Click);
            // 
            // BtnRfrsDtGrdVwRegSuc
            // 
            this.BtnRfrsDtGrdVwRegSuc.Location = new System.Drawing.Point(319, 349);
            this.BtnRfrsDtGrdVwRegSuc.Name = "BtnRfrsDtGrdVwRegSuc";
            this.BtnRfrsDtGrdVwRegSuc.Size = new System.Drawing.Size(75, 23);
            this.BtnRfrsDtGrdVwRegSuc.TabIndex = 19;
            this.BtnRfrsDtGrdVwRegSuc.Text = "Refrescar";
            this.BtnRfrsDtGrdVwRegSuc.UseVisualStyleBackColor = true;
            this.BtnRfrsDtGrdVwRegSuc.Click += new System.EventHandler(this.BtnRfrsDtGrdVwRegSuc_Click);
            // 
            // RegSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 400);
            this.Controls.Add(this.BtnRfrsDtGrdVwRegSuc);
            this.Controls.Add(this.BtnReactivarSuc);
            this.Controls.Add(this.lblMsgErrorSuc);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BtnDescSuc);
            this.Controls.Add(this.DtGrdVwTabSuc);
            this.Controls.Add(this.BtnRegSuc);
            this.Controls.Add(this.CmbBxSelecCiudRegSuc);
            this.Controls.Add(this.txtRegSuc);
            this.Controls.Add(this.lblRegCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegSuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegSuc";
            this.Load += new System.EventHandler(this.RegSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwTabSuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegCiudad;
        private System.Windows.Forms.TextBox txtRegSuc;
        private System.Windows.Forms.ComboBox CmbBxSelecCiudRegSuc;
        private System.Windows.Forms.Button BtnRegSuc;
        private System.Windows.Forms.DataGridView DtGrdVwTabSuc;
        private System.Windows.Forms.Button BtnDescSuc;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblMsgErrorSuc;
        private System.Windows.Forms.Button BtnReactivarSuc;
        private System.Windows.Forms.Button BtnRfrsDtGrdVwRegSuc;
    }
}