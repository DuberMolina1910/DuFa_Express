namespace DuFa_express
{
    partial class HabCiud
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
            this.BtnCanclHabCiu = new System.Windows.Forms.Button();
            this.BtnHabCiu = new System.Windows.Forms.Button();
            this.DtGrdVwHabCiu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwHabCiu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCanclHabCiu
            // 
            this.BtnCanclHabCiu.Location = new System.Drawing.Point(198, 266);
            this.BtnCanclHabCiu.Name = "BtnCanclHabCiu";
            this.BtnCanclHabCiu.Size = new System.Drawing.Size(108, 38);
            this.BtnCanclHabCiu.TabIndex = 5;
            this.BtnCanclHabCiu.Text = "Cancelar";
            this.BtnCanclHabCiu.UseVisualStyleBackColor = true;
            // 
            // BtnHabCiu
            // 
            this.BtnHabCiu.Location = new System.Drawing.Point(39, 266);
            this.BtnHabCiu.Name = "BtnHabCiu";
            this.BtnHabCiu.Size = new System.Drawing.Size(108, 38);
            this.BtnHabCiu.TabIndex = 4;
            this.BtnHabCiu.Text = "Habilitar";
            this.BtnHabCiu.UseVisualStyleBackColor = true;
            this.BtnHabCiu.Click += new System.EventHandler(this.BtnHabCiu_Click);
            // 
            // DtGrdVwHabCiu
            // 
            this.DtGrdVwHabCiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdVwHabCiu.Location = new System.Drawing.Point(39, 34);
            this.DtGrdVwHabCiu.Name = "DtGrdVwHabCiu";
            this.DtGrdVwHabCiu.Size = new System.Drawing.Size(267, 192);
            this.DtGrdVwHabCiu.TabIndex = 3;
            this.DtGrdVwHabCiu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdVwHabCiu_CellContentClick);
            // 
            // HabCiud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.BtnCanclHabCiu);
            this.Controls.Add(this.BtnHabCiu);
            this.Controls.Add(this.DtGrdVwHabCiu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HabCiud";
            this.Text = "HabCiud";
            this.Load += new System.EventHandler(this.HabCiud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdVwHabCiu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCanclHabCiu;
        private System.Windows.Forms.Button BtnHabCiu;
        private System.Windows.Forms.DataGridView DtGrdVwHabCiu;
    }
}