namespace DuFa_express
{
    partial class PerfilClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrearPerfilC = new System.Windows.Forms.Button();
            this.BtnActualizarEnvioC = new System.Windows.Forms.Button();
            this.BtnSoliciAnulacC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // BtnCrearPerfilC
            // 
            this.BtnCrearPerfilC.Location = new System.Drawing.Point(122, 110);
            this.BtnCrearPerfilC.Name = "BtnCrearPerfilC";
            this.BtnCrearPerfilC.Size = new System.Drawing.Size(162, 48);
            this.BtnCrearPerfilC.TabIndex = 1;
            this.BtnCrearPerfilC.Text = "Nuevo Envio";
            this.BtnCrearPerfilC.UseVisualStyleBackColor = true;
            // 
            // BtnActualizarEnvioC
            // 
            this.BtnActualizarEnvioC.Location = new System.Drawing.Point(122, 212);
            this.BtnActualizarEnvioC.Name = "BtnActualizarEnvioC";
            this.BtnActualizarEnvioC.Size = new System.Drawing.Size(162, 48);
            this.BtnActualizarEnvioC.TabIndex = 2;
            this.BtnActualizarEnvioC.Text = "Actualizacion de envio";
            this.BtnActualizarEnvioC.UseVisualStyleBackColor = true;
            // 
            // BtnSoliciAnulacC
            // 
            this.BtnSoliciAnulacC.Location = new System.Drawing.Point(122, 318);
            this.BtnSoliciAnulacC.Name = "BtnSoliciAnulacC";
            this.BtnSoliciAnulacC.Size = new System.Drawing.Size(162, 48);
            this.BtnSoliciAnulacC.TabIndex = 3;
            this.BtnSoliciAnulacC.Text = "Solicitar Anulacion";
            this.BtnSoliciAnulacC.UseVisualStyleBackColor = true;
            // 
            // PerfilClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 494);
            this.Controls.Add(this.BtnSoliciAnulacC);
            this.Controls.Add(this.BtnActualizarEnvioC);
            this.Controls.Add(this.BtnCrearPerfilC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilClientForm";
            this.Text = "PerfilCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCrearPerfilC;
        private System.Windows.Forms.Button BtnActualizarEnvioC;
        private System.Windows.Forms.Button BtnSoliciAnulacC;
    }
}