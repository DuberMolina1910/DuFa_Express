﻿namespace DuFa_express
{
    partial class CalcValor
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
            this.cmbCiudadOri = new System.Windows.Forms.ComboBox();
            this.cmbCiudadDes = new System.Windows.Forms.ComboBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCiudadOri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCiudadOri
            // 
            this.cmbCiudadOri.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbCiudadOri.FormattingEnabled = true;
            this.cmbCiudadOri.Location = new System.Drawing.Point(163, 97);
            this.cmbCiudadOri.Name = "cmbCiudadOri";
            this.cmbCiudadOri.Size = new System.Drawing.Size(159, 25);
            this.cmbCiudadOri.TabIndex = 0;
            // 
            // cmbCiudadDes
            // 
            this.cmbCiudadDes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbCiudadDes.FormattingEnabled = true;
            this.cmbCiudadDes.Location = new System.Drawing.Point(163, 135);
            this.cmbCiudadDes.Name = "cmbCiudadDes";
            this.cmbCiudadDes.Size = new System.Drawing.Size(159, 25);
            this.cmbCiudadDes.TabIndex = 1;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeguro.Location = new System.Drawing.Point(163, 173);
            this.txtSeguro.Multiline = true;
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(159, 25);
            this.txtSeguro.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPeso.Location = new System.Drawing.Point(163, 211);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(159, 25);
            this.txtPeso.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(163, 268);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(159, 23);
            this.btnCalc.TabIndex = 145;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(12, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(348, 57);
            this.lblInfo.TabIndex = 146;
            this.lblInfo.Text = "Recuerde que al declarar un valor se adquiere un seguro lo cual aumenta el valor " +
    "total del envío, en caso de no adquirir el seguro la empresa";
            // 
            // lblCiudadOri
            // 
            this.lblCiudadOri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadOri.Location = new System.Drawing.Point(25, 99);
            this.lblCiudadOri.Name = "lblCiudadOri";
            this.lblCiudadOri.Size = new System.Drawing.Size(132, 23);
            this.lblCiudadOri.TabIndex = 147;
            this.lblCiudadOri.Text = "Ciudad Origen";
            this.lblCiudadOri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 148;
            this.label1.Text = "Ciudad Destino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 149;
            this.label2.Text = "Valor Declarado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 150;
            this.label3.Text = "Peso Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalcValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCiudadOri);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.cmbCiudadDes);
            this.Controls.Add(this.cmbCiudadOri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcular Valor";
            this.Load += new System.EventHandler(this.CalcValor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiudadOri;
        private System.Windows.Forms.ComboBox cmbCiudadDes;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCiudadOri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}