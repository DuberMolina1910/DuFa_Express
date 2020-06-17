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
            // GesEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.dgvGesEnvios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesEnvios";
            this.Text = "GesEnvios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGesEnvios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGesEnvios;
    }
}