﻿namespace DuFa_express
{
    partial class RegCiudad
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
            this.btnRegCiudad = new System.Windows.Forms.Button();
            this.lblRegCiudad = new System.Windows.Forms.Label();
            this.txtRegCiudad = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.DtGrdVTabCiudades = new System.Windows.Forms.DataGridView();
            this.btnDesacCiudad = new System.Windows.Forms.Button();
            this.btnCancelarCiudad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVTabCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegCiudad
            // 
            this.btnRegCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCiudad.Location = new System.Drawing.Point(363, 168);
            this.btnRegCiudad.Name = "btnRegCiudad";
            this.btnRegCiudad.Size = new System.Drawing.Size(100, 25);
            this.btnRegCiudad.TabIndex = 1;
            this.btnRegCiudad.Text = "AGREGAR";
            this.btnRegCiudad.UseVisualStyleBackColor = true;
            this.btnRegCiudad.Click += new System.EventHandler(this.btnRegCiudad_Click);
            // 
            // lblRegCiudad
            // 
            this.lblRegCiudad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCiudad.Location = new System.Drawing.Point(0, 0);
            this.lblRegCiudad.Name = "lblRegCiudad";
            this.lblRegCiudad.Size = new System.Drawing.Size(475, 100);
            this.lblRegCiudad.TabIndex = 0;
            this.lblRegCiudad.Text = "REGISTRO DE  CIUDADES";
            this.lblRegCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegCiudad
            // 
            this.txtRegCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegCiudad.Location = new System.Drawing.Point(107, 103);
            this.txtRegCiudad.Name = "txtRegCiudad";
            this.txtRegCiudad.Size = new System.Drawing.Size(264, 23);
            this.txtRegCiudad.TabIndex = 2;
            this.txtRegCiudad.Text = "NOMBRE DE LA CIUDAD";
            this.txtRegCiudad.TextChanged += new System.EventHandler(this.txtRegCiudad_TextChanged);
            this.txtRegCiudad.Enter += new System.EventHandler(this.txtRegCiudad_Enter);
            this.txtRegCiudad.Leave += new System.EventHandler(this.txtRegCiudad_Leave);
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsgError.Location = new System.Drawing.Point(104, 129);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(34, 17);
            this.lblMsgError.TabIndex = 16;
            this.lblMsgError.Text = "Error";
            this.lblMsgError.Visible = false;
            // 
            // DtGrdVTabCiudades
            // 
            this.DtGrdVTabCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVTabCiudades.Location = new System.Drawing.Point(83, 168);
            this.DtGrdVTabCiudades.Name = "DtGrdVTabCiudades";
            this.DtGrdVTabCiudades.Size = new System.Drawing.Size(243, 150);
            this.DtGrdVTabCiudades.TabIndex = 17;
            this.DtGrdVTabCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDesacCiudad
            // 
            this.btnDesacCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesacCiudad.Location = new System.Drawing.Point(363, 199);
            this.btnDesacCiudad.Name = "btnDesacCiudad";
            this.btnDesacCiudad.Size = new System.Drawing.Size(100, 25);
            this.btnDesacCiudad.TabIndex = 18;
            this.btnDesacCiudad.Text = "DESACTIVAR";
            this.btnDesacCiudad.UseVisualStyleBackColor = true;
            this.btnDesacCiudad.Click += new System.EventHandler(this.btnElimCiudad_Click);
            // 
            // btnCancelarCiudad
            // 
            this.btnCancelarCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCiudad.Location = new System.Drawing.Point(38, 351);
            this.btnCancelarCiudad.Name = "btnCancelarCiudad";
            this.btnCancelarCiudad.Size = new System.Drawing.Size(100, 25);
            this.btnCancelarCiudad.TabIndex = 19;
            this.btnCancelarCiudad.Text = "REGRESAR";
            this.btnCancelarCiudad.UseVisualStyleBackColor = true;
            this.btnCancelarCiudad.Click += new System.EventHandler(this.btnCancelarCiudad_Click);
            // 
            // RegCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 400);
            this.Controls.Add(this.btnCancelarCiudad);
            this.Controls.Add(this.btnDesacCiudad);
            this.Controls.Add(this.DtGrdVTabCiudades);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.txtRegCiudad);
            this.Controls.Add(this.btnRegCiudad);
            this.Controls.Add(this.lblRegCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegCiudad";
            this.Load += new System.EventHandler(this.RegCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVTabCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegCiudad;
        private System.Windows.Forms.Label lblRegCiudad;
        private System.Windows.Forms.TextBox txtRegCiudad;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.DataGridView DtGrdVTabCiudades;
        private System.Windows.Forms.Button btnDesacCiudad;
        private System.Windows.Forms.Button btnCancelarCiudad;
    }
}