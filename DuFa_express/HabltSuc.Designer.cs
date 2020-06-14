namespace DuFa_express
{
    partial class HabltSuc
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
            this.DtGrdVwHabSuc = new System.Windows.Forms.DataGridView();
            this.BtnHabSuc = new System.Windows.Forms.Button();
            this.BtnCanclHabSuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwHabSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGrdVwHabSuc
            // 
            this.DtGrdVwHabSuc.AllowUserToAddRows = false;
            this.DtGrdVwHabSuc.AllowUserToDeleteRows = false;
            this.DtGrdVwHabSuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdVwHabSuc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DtGrdVwHabSuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrdVwHabSuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGrdVwHabSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwHabSuc.Location = new System.Drawing.Point(44, 29);
            this.DtGrdVwHabSuc.Name = "DtGrdVwHabSuc";
            this.DtGrdVwHabSuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGrdVwHabSuc.Size = new System.Drawing.Size(267, 192);
            this.DtGrdVwHabSuc.TabIndex = 0;
            // 
            // BtnHabSuc
            // 
            this.BtnHabSuc.Location = new System.Drawing.Point(44, 261);
            this.BtnHabSuc.Name = "BtnHabSuc";
            this.BtnHabSuc.Size = new System.Drawing.Size(108, 38);
            this.BtnHabSuc.TabIndex = 1;
            this.BtnHabSuc.Text = "Habilitar";
            this.BtnHabSuc.UseVisualStyleBackColor = true;
            this.BtnHabSuc.Click += new System.EventHandler(this.BtnHabSuc_Click);
            // 
            // BtnCanclHabSuc
            // 
            this.BtnCanclHabSuc.Location = new System.Drawing.Point(203, 261);
            this.BtnCanclHabSuc.Name = "BtnCanclHabSuc";
            this.BtnCanclHabSuc.Size = new System.Drawing.Size(108, 38);
            this.BtnCanclHabSuc.TabIndex = 2;
            this.BtnCanclHabSuc.Text = "Cancelar";
            this.BtnCanclHabSuc.UseVisualStyleBackColor = true;
            this.BtnCanclHabSuc.Click += new System.EventHandler(this.BtnCanclHabSuc_Click);
            // 
            // HabltSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.BtnCanclHabSuc);
            this.Controls.Add(this.BtnHabSuc);
            this.Controls.Add(this.DtGrdVwHabSuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HabltSuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HabltSuc";
            this.Load += new System.EventHandler(this.HabltSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwHabSuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGrdVwHabSuc;
        private System.Windows.Forms.Button BtnHabSuc;
        private System.Windows.Forms.Button BtnCanclHabSuc;
    }
}