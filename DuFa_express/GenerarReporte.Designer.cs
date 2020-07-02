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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrarGenRepPerAdm = new System.Windows.Forms.Button();
            this.BtnExlGenRepPerAdm = new System.Windows.Forms.Button();
            this.DtGrdVwGenRepPerAdm = new System.Windows.Forms.DataGridView();
            this.LblTiposReportes = new System.Windows.Forms.Label();
            this.CmbBxTipRepGenRepPerAdm = new System.Windows.Forms.ComboBox();
            this.lblRepInformes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwGenRepPerAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarGenRepPerAdm
            // 
            this.BtnCerrarGenRepPerAdm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarGenRepPerAdm.Location = new System.Drawing.Point(569, 449);
            this.BtnCerrarGenRepPerAdm.Name = "BtnCerrarGenRepPerAdm";
            this.BtnCerrarGenRepPerAdm.Size = new System.Drawing.Size(119, 29);
            this.BtnCerrarGenRepPerAdm.TabIndex = 0;
            this.BtnCerrarGenRepPerAdm.Text = "Cerrar";
            this.BtnCerrarGenRepPerAdm.UseVisualStyleBackColor = true;
            this.BtnCerrarGenRepPerAdm.Click += new System.EventHandler(this.BtnCerrarGenRepPerAdm_Click);
            // 
            // BtnExlGenRepPerAdm
            // 
            this.BtnExlGenRepPerAdm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnExlGenRepPerAdm.Location = new System.Drawing.Point(488, 113);
            this.BtnExlGenRepPerAdm.Name = "BtnExlGenRepPerAdm";
            this.BtnExlGenRepPerAdm.Size = new System.Drawing.Size(120, 35);
            this.BtnExlGenRepPerAdm.TabIndex = 1;
            this.BtnExlGenRepPerAdm.Text = "Generar Excel";
            this.BtnExlGenRepPerAdm.UseVisualStyleBackColor = true;
            this.BtnExlGenRepPerAdm.Click += new System.EventHandler(this.BtnExlGenRepPerAdm_Click);
            // 
            // DtGrdVwGenRepPerAdm
            // 
            this.DtGrdVwGenRepPerAdm.AllowUserToAddRows = false;
            this.DtGrdVwGenRepPerAdm.AllowUserToDeleteRows = false;
            this.DtGrdVwGenRepPerAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdVwGenRepPerAdm.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DtGrdVwGenRepPerAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtGrdVwGenRepPerAdm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrdVwGenRepPerAdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGrdVwGenRepPerAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwGenRepPerAdm.Location = new System.Drawing.Point(12, 163);
            this.DtGrdVwGenRepPerAdm.Name = "DtGrdVwGenRepPerAdm";
            this.DtGrdVwGenRepPerAdm.RowHeadersVisible = false;
            this.DtGrdVwGenRepPerAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGrdVwGenRepPerAdm.Size = new System.Drawing.Size(676, 270);
            this.DtGrdVwGenRepPerAdm.TabIndex = 2;
            this.DtGrdVwGenRepPerAdm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdVwGenRepPerAdm_CellContentClick);
            // 
            // LblTiposReportes
            // 
            this.LblTiposReportes.AutoSize = true;
            this.LblTiposReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiposReportes.Location = new System.Drawing.Point(12, 124);
            this.LblTiposReportes.Name = "LblTiposReportes";
            this.LblTiposReportes.Size = new System.Drawing.Size(136, 18);
            this.LblTiposReportes.TabIndex = 4;
            this.LblTiposReportes.Text = "Tipos de Reportes";
            // 
            // CmbBxTipRepGenRepPerAdm
            // 
            this.CmbBxTipRepGenRepPerAdm.FormattingEnabled = true;
            this.CmbBxTipRepGenRepPerAdm.Items.AddRange(new object[] {
            "",
            "Consulta Usuarios del Sistema",
            "Consulta Asignacion de Usuarios - Sucursales",
            "Consulta de Envios por sucursales",
            "Consulta de Envios Cancelados"});
            this.CmbBxTipRepGenRepPerAdm.Location = new System.Drawing.Point(154, 121);
            this.CmbBxTipRepGenRepPerAdm.Name = "CmbBxTipRepGenRepPerAdm";
            this.CmbBxTipRepGenRepPerAdm.Size = new System.Drawing.Size(250, 21);
            this.CmbBxTipRepGenRepPerAdm.TabIndex = 5;
            this.CmbBxTipRepGenRepPerAdm.SelectedIndexChanged += new System.EventHandler(this.CmbBxTipRepGenRepPerAdm_SelectedIndexChanged);
            // 
            // lblRepInformes
            // 
            this.lblRepInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRepInformes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepInformes.Location = new System.Drawing.Point(0, 0);
            this.lblRepInformes.Name = "lblRepInformes";
            this.lblRepInformes.Size = new System.Drawing.Size(700, 75);
            this.lblRepInformes.TabIndex = 6;
            this.lblRepInformes.Text = "Reportes/Informes";
            this.lblRepInformes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.lblRepInformes);
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
        private System.Windows.Forms.Label lblRepInformes;
    }
}