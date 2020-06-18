namespace DuFa_express
{
    partial class GenerarReporte
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
            this.BtnCerrarGenRepPerAdm = new System.Windows.Forms.Button();
            this.BtnExlGenRepPerAdm = new System.Windows.Forms.Button();
            this.DtGrdVwGenRepPerAdm = new System.Windows.Forms.DataGridView();
            this.LblTiposReportes = new System.Windows.Forms.Label();
            this.CmbBxTipRepGenRepPerAdm = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwGenRepPerAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarGenRepPerAdm
            // 
            this.BtnCerrarGenRepPerAdm.Location = new System.Drawing.Point(36, 452);
            this.BtnCerrarGenRepPerAdm.Name = "BtnCerrarGenRepPerAdm";
            this.BtnCerrarGenRepPerAdm.Size = new System.Drawing.Size(113, 26);
            this.BtnCerrarGenRepPerAdm.TabIndex = 0;
            this.BtnCerrarGenRepPerAdm.Text = "Cerrar";
            this.BtnCerrarGenRepPerAdm.UseVisualStyleBackColor = true;
            this.BtnCerrarGenRepPerAdm.Click += new System.EventHandler(this.BtnCerrarGenRepPerAdm_Click);
            // 
            // BtnExlGenRepPerAdm
            // 
            this.BtnExlGenRepPerAdm.Location = new System.Drawing.Point(575, 418);
            this.BtnExlGenRepPerAdm.Name = "BtnExlGenRepPerAdm";
            this.BtnExlGenRepPerAdm.Size = new System.Drawing.Size(113, 26);
            this.BtnExlGenRepPerAdm.TabIndex = 1;
            this.BtnExlGenRepPerAdm.Text = "Generar Excel";
            this.BtnExlGenRepPerAdm.UseVisualStyleBackColor = true;
            // 
            // DtGrdVwGenRepPerAdm
            // 
            this.DtGrdVwGenRepPerAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwGenRepPerAdm.Location = new System.Drawing.Point(12, 142);
            this.DtGrdVwGenRepPerAdm.Name = "DtGrdVwGenRepPerAdm";
            this.DtGrdVwGenRepPerAdm.Size = new System.Drawing.Size(676, 270);
            this.DtGrdVwGenRepPerAdm.TabIndex = 2;
            // 
            // LblTiposReportes
            // 
            this.LblTiposReportes.AutoSize = true;
            this.LblTiposReportes.Location = new System.Drawing.Point(33, 89);
            this.LblTiposReportes.Name = "LblTiposReportes";
            this.LblTiposReportes.Size = new System.Drawing.Size(94, 13);
            this.LblTiposReportes.TabIndex = 4;
            this.LblTiposReportes.Text = "Tipos de Reportes";
            // 
            // CmbBxTipRepGenRepPerAdm
            // 
            this.CmbBxTipRepGenRepPerAdm.FormattingEnabled = true;
            this.CmbBxTipRepGenRepPerAdm.Items.AddRange(new object[] {
            "",
            "Consulta Asignacion de Usuarios - Sucursales",
            "Consulta Usuarios del Sistema",
            "Consulta de Envios por sucursales"});
            this.CmbBxTipRepGenRepPerAdm.Location = new System.Drawing.Point(170, 86);
            this.CmbBxTipRepGenRepPerAdm.Name = "CmbBxTipRepGenRepPerAdm";
            this.CmbBxTipRepGenRepPerAdm.Size = new System.Drawing.Size(250, 21);
            this.CmbBxTipRepGenRepPerAdm.TabIndex = 5;
            this.CmbBxTipRepGenRepPerAdm.SelectedIndexChanged += new System.EventHandler(this.CmbBxTipRepGenRepPerAdm_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(228, 22);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(94, 13);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Tipos de Reportes";
            // 
            // GenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.CmbBxTipRepGenRepPerAdm);
            this.Controls.Add(this.LblTiposReportes);
            this.Controls.Add(this.DtGrdVwGenRepPerAdm);
            this.Controls.Add(this.BtnExlGenRepPerAdm);
            this.Controls.Add(this.BtnCerrarGenRepPerAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarReporte";
            this.Text = "GenerarReporte";
            this.Load += new System.EventHandler(this.GenerarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwGenRepPerAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarGenRepPerAdm;
        private System.Windows.Forms.Button BtnExlGenRepPerAdm;
        private System.Windows.Forms.DataGridView DtGrdVwGenRepPerAdm;
        private System.Windows.Forms.Label LblTiposReportes;
        private System.Windows.Forms.ComboBox CmbBxTipRepGenRepPerAdm;
        private System.Windows.Forms.Label LblTitulo;
    }
}