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
            this.button1 = new System.Windows.Forms.Button();
            this.DtGrdVwTabSuc = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.txtRegSuc.Location = new System.Drawing.Point(50, 161);
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
            this.CmbBxSelecCiudRegSuc.Location = new System.Drawing.Point(50, 131);
            this.CmbBxSelecCiudRegSuc.Name = "CmbBxSelecCiudRegSuc";
            this.CmbBxSelecCiudRegSuc.Size = new System.Drawing.Size(264, 24);
            this.CmbBxSelecCiudRegSuc.TabIndex = 4;
            this.CmbBxSelecCiudRegSuc.Text = "SELECCIONE CIUDAD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar Sucursal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtGrdVwTabSuc
            // 
            this.DtGrdVwTabSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwTabSuc.Location = new System.Drawing.Point(50, 204);
            this.DtGrdVwTabSuc.Name = "DtGrdVwTabSuc";
            this.DtGrdVwTabSuc.Size = new System.Drawing.Size(344, 139);
            this.DtGrdVwTabSuc.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deshabilitar Sucursal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 24);
            this.button3.TabIndex = 8;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 400);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DtGrdVwTabSuc);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DtGrdVwTabSuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}