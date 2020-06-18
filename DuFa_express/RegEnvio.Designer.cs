namespace DuFa_express
{
    partial class RegEnvio
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
            this.components = new System.ComponentModel.Container();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.lblTipoPer = new System.Windows.Forms.Label();
            this.cmbIdSucOri = new System.Windows.Forms.ComboBox();
            this.lblIdSucOri = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumId = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDirDes = new System.Windows.Forms.TextBox();
            this.txtTelDes = new System.Windows.Forms.TextBox();
            this.txtNumGuia = new System.Windows.Forms.TextBox();
            this.lblTitleReg = new System.Windows.Forms.Label();
            this.lblDirDes = new System.Windows.Forms.Label();
            this.lblTelDes = new System.Windows.Forms.Label();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.lblIdSucDes = new System.Windows.Forms.Label();
            this.lblIdGuia = new System.Windows.Forms.Label();
            this.cmbIdSucDes = new System.Windows.Forms.ComboBox();
            this.lblNumIdDes = new System.Windows.Forms.Label();
            this.txtNumIdDes = new System.Windows.Forms.TextBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.txtNomDes = new System.Windows.Forms.TextBox();
            this.lblNomDes = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNomUsu = new System.Windows.Forms.Label();
            this.lblCorreoUsu = new System.Windows.Forms.Label();
            this.lblTelUsu = new System.Windows.Forms.Label();
            this.lblDirUsu = new System.Windows.Forms.Label();
            this.txtDetEnvio = new System.Windows.Forms.TextBox();
            this.lblNomValEnvio = new System.Windows.Forms.Label();
            this.lblValEnvio = new System.Windows.Forms.Label();
            this.cmbTipoUsu = new System.Windows.Forms.ComboBox();
            this.cmbTipoPer = new System.Windows.Forms.ComboBox();
            this.lblShowFechaEnvio = new System.Windows.Forms.Label();
            this.timerFechaEnvio = new System.Windows.Forms.Timer(this.components);
            this.btnNuevoReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMsgError.Location = new System.Drawing.Point(433, 297);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(34, 17);
            this.lblMsgError.TabIndex = 134;
            this.lblMsgError.Text = "Error";
            this.lblMsgError.Visible = false;
            // 
            // lblTipoPer
            // 
            this.lblTipoPer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPer.Location = new System.Drawing.Point(12, 148);
            this.lblTipoPer.Name = "lblTipoPer";
            this.lblTipoPer.Size = new System.Drawing.Size(105, 23);
            this.lblTipoPer.TabIndex = 132;
            this.lblTipoPer.Text = "Tipo de Perfil";
            this.lblTipoPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbIdSucOri
            // 
            this.cmbIdSucOri.Enabled = false;
            this.cmbIdSucOri.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbIdSucOri.FormattingEnabled = true;
            this.cmbIdSucOri.Location = new System.Drawing.Point(209, 210);
            this.cmbIdSucOri.Name = "cmbIdSucOri";
            this.cmbIdSucOri.Size = new System.Drawing.Size(200, 25);
            this.cmbIdSucOri.TabIndex = 6;
            // 
            // lblIdSucOri
            // 
            this.lblIdSucOri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSucOri.Location = new System.Drawing.Point(12, 210);
            this.lblIdSucOri.Name = "lblIdSucOri";
            this.lblIdSucOri.Size = new System.Drawing.Size(106, 23);
            this.lblIdSucOri.TabIndex = 130;
            this.lblIdSucOri.Text = "Sucursal Origen";
            this.lblIdSucOri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 181);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(105, 23);
            this.lblEstado.TabIndex = 128;
            this.lblEstado.Text = "Estado Envío";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(436, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 25);
            this.btnCancelar.TabIndex = 127;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumId
            // 
            this.lblNumId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumId.Location = new System.Drawing.Point(12, 119);
            this.lblNumId.Name = "lblNumId";
            this.lblNumId.Size = new System.Drawing.Size(173, 23);
            this.lblNumId.TabIndex = 126;
            this.lblNumId.Text = "Numero de Identificacion";
            this.lblNumId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(436, 394);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(142, 25);
            this.btnConfirmar.TabIndex = 125;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtDirDes
            // 
            this.txtDirDes.Enabled = false;
            this.txtDirDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirDes.Location = new System.Drawing.Point(209, 380);
            this.txtDirDes.Name = "txtDirDes";
            this.txtDirDes.Size = new System.Drawing.Size(200, 23);
            this.txtDirDes.TabIndex = 11;
            // 
            // txtTelDes
            // 
            this.txtTelDes.Enabled = false;
            this.txtTelDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelDes.Location = new System.Drawing.Point(209, 351);
            this.txtTelDes.Name = "txtTelDes";
            this.txtTelDes.Size = new System.Drawing.Size(200, 23);
            this.txtTelDes.TabIndex = 10;
            // 
            // txtNumGuia
            // 
            this.txtNumGuia.Enabled = false;
            this.txtNumGuia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuia.Location = new System.Drawing.Point(209, 90);
            this.txtNumGuia.Name = "txtNumGuia";
            this.txtNumGuia.Size = new System.Drawing.Size(200, 23);
            this.txtNumGuia.TabIndex = 1;
            // 
            // lblTitleReg
            // 
            this.lblTitleReg.AutoSize = true;
            this.lblTitleReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleReg.Location = new System.Drawing.Point(121, 7);
            this.lblTitleReg.Name = "lblTitleReg";
            this.lblTitleReg.Size = new System.Drawing.Size(200, 19);
            this.lblTitleReg.TabIndex = 124;
            this.lblTitleReg.Text = "Formulario Registro Envío";
            // 
            // lblDirDes
            // 
            this.lblDirDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirDes.Location = new System.Drawing.Point(12, 380);
            this.lblDirDes.Name = "lblDirDes";
            this.lblDirDes.Size = new System.Drawing.Size(155, 23);
            this.lblDirDes.TabIndex = 121;
            this.lblDirDes.Text = "Direccion Destinatario";
            this.lblDirDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelDes
            // 
            this.lblTelDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelDes.Location = new System.Drawing.Point(12, 351);
            this.lblTelDes.Name = "lblTelDes";
            this.lblTelDes.Size = new System.Drawing.Size(151, 23);
            this.lblTelDes.TabIndex = 119;
            this.lblTelDes.Text = "Telefono Destinatario";
            this.lblTelDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEnvio.Location = new System.Drawing.Point(12, 60);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(173, 23);
            this.lblFechaEnvio.TabIndex = 118;
            this.lblFechaEnvio.Text = "Fecha Creación de Envío";
            this.lblFechaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdSucDes
            // 
            this.lblIdSucDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSucDes.Location = new System.Drawing.Point(12, 243);
            this.lblIdSucDes.Name = "lblIdSucDes";
            this.lblIdSucDes.Size = new System.Drawing.Size(111, 23);
            this.lblIdSucDes.TabIndex = 117;
            this.lblIdSucDes.Text = "Sucursal Destino";
            this.lblIdSucDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdGuia
            // 
            this.lblIdGuia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGuia.Location = new System.Drawing.Point(12, 90);
            this.lblIdGuia.Name = "lblIdGuia";
            this.lblIdGuia.Size = new System.Drawing.Size(132, 23);
            this.lblIdGuia.TabIndex = 116;
            this.lblIdGuia.Text = "N° de Guia/Envío";
            this.lblIdGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbIdSucDes
            // 
            this.cmbIdSucDes.Enabled = false;
            this.cmbIdSucDes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbIdSucDes.FormattingEnabled = true;
            this.cmbIdSucDes.Location = new System.Drawing.Point(209, 241);
            this.cmbIdSucDes.Name = "cmbIdSucDes";
            this.cmbIdSucDes.Size = new System.Drawing.Size(200, 25);
            this.cmbIdSucDes.TabIndex = 7;
            // 
            // lblNumIdDes
            // 
            this.lblNumIdDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIdDes.Location = new System.Drawing.Point(12, 275);
            this.lblNumIdDes.Name = "lblNumIdDes";
            this.lblNumIdDes.Size = new System.Drawing.Size(173, 39);
            this.lblNumIdDes.TabIndex = 139;
            this.lblNumIdDes.Text = "Numero de Identificacion Destinatario";
            this.lblNumIdDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumIdDes
            // 
            this.txtNumIdDes.Enabled = false;
            this.txtNumIdDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIdDes.Location = new System.Drawing.Point(209, 283);
            this.txtNumIdDes.Name = "txtNumIdDes";
            this.txtNumIdDes.Size = new System.Drawing.Size(200, 23);
            this.txtNumIdDes.TabIndex = 8;
            // 
            // txtNumId
            // 
            this.txtNumId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumId.Location = new System.Drawing.Point(209, 119);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(200, 23);
            this.txtNumId.TabIndex = 2;
            // 
            // txtNomDes
            // 
            this.txtNomDes.Enabled = false;
            this.txtNomDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDes.Location = new System.Drawing.Point(209, 322);
            this.txtNomDes.Name = "txtNomDes";
            this.txtNomDes.Size = new System.Drawing.Size(200, 23);
            this.txtNomDes.TabIndex = 9;
            // 
            // lblNomDes
            // 
            this.lblNomDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDes.Location = new System.Drawing.Point(12, 322);
            this.lblNomDes.Name = "lblNomDes";
            this.lblNomDes.Size = new System.Drawing.Size(151, 23);
            this.lblNomDes.TabIndex = 143;
            this.lblNomDes.Text = "Nombre Destinatario";
            this.lblNomDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(436, 365);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(142, 25);
            this.btnBuscar.TabIndex = 144;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.AutoSize = true;
            this.lblNomUsu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomUsu.Location = new System.Drawing.Point(384, 9);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(102, 17);
            this.lblNomUsu.TabIndex = 145;
            this.lblNomUsu.Text = "Nombre Usuario";
            this.lblNomUsu.Visible = false;
            this.lblNomUsu.Click += new System.EventHandler(this.lblNomUsu_Click);
            // 
            // lblCorreoUsu
            // 
            this.lblCorreoUsu.AutoSize = true;
            this.lblCorreoUsu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorreoUsu.Location = new System.Drawing.Point(384, 26);
            this.lblCorreoUsu.Name = "lblCorreoUsu";
            this.lblCorreoUsu.Size = new System.Drawing.Size(95, 17);
            this.lblCorreoUsu.TabIndex = 146;
            this.lblCorreoUsu.Text = "Correo Usuario";
            this.lblCorreoUsu.Visible = false;
            // 
            // lblTelUsu
            // 
            this.lblTelUsu.AutoSize = true;
            this.lblTelUsu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelUsu.Location = new System.Drawing.Point(384, 44);
            this.lblTelUsu.Name = "lblTelUsu";
            this.lblTelUsu.Size = new System.Drawing.Size(105, 17);
            this.lblTelUsu.TabIndex = 147;
            this.lblTelUsu.Text = "Telefono Usuario";
            this.lblTelUsu.Visible = false;
            // 
            // lblDirUsu
            // 
            this.lblDirUsu.AutoSize = true;
            this.lblDirUsu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDirUsu.Location = new System.Drawing.Point(384, 61);
            this.lblDirUsu.Name = "lblDirUsu";
            this.lblDirUsu.Size = new System.Drawing.Size(112, 17);
            this.lblDirUsu.TabIndex = 148;
            this.lblDirUsu.Text = "Dirección Usuario";
            this.lblDirUsu.Visible = false;
            // 
            // txtDetEnvio
            // 
            this.txtDetEnvio.Enabled = false;
            this.txtDetEnvio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetEnvio.Location = new System.Drawing.Point(436, 98);
            this.txtDetEnvio.Multiline = true;
            this.txtDetEnvio.Name = "txtDetEnvio";
            this.txtDetEnvio.Size = new System.Drawing.Size(142, 176);
            this.txtDetEnvio.TabIndex = 149;
            this.txtDetEnvio.Text = "Por favor haga una breve descripción del envío";
            // 
            // lblNomValEnvio
            // 
            this.lblNomValEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomValEnvio.Location = new System.Drawing.Point(84, 444);
            this.lblNomValEnvio.Name = "lblNomValEnvio";
            this.lblNomValEnvio.Size = new System.Drawing.Size(101, 23);
            this.lblNomValEnvio.TabIndex = 151;
            this.lblNomValEnvio.Text = "Valor Total:";
            this.lblNomValEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValEnvio
            // 
            this.lblValEnvio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValEnvio.Location = new System.Drawing.Point(188, 438);
            this.lblValEnvio.Name = "lblValEnvio";
            this.lblValEnvio.Size = new System.Drawing.Size(145, 35);
            this.lblValEnvio.TabIndex = 152;
            this.lblValEnvio.Text = "COP $0";
            this.lblValEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipoUsu
            // 
            this.cmbTipoUsu.Enabled = false;
            this.cmbTipoUsu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbTipoUsu.FormattingEnabled = true;
            this.cmbTipoUsu.Location = new System.Drawing.Point(209, 179);
            this.cmbTipoUsu.Name = "cmbTipoUsu";
            this.cmbTipoUsu.Size = new System.Drawing.Size(200, 25);
            this.cmbTipoUsu.TabIndex = 3;
            this.cmbTipoUsu.Text = "Creado";
            // 
            // cmbTipoPer
            // 
            this.cmbTipoPer.Enabled = false;
            this.cmbTipoPer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbTipoPer.FormattingEnabled = true;
            this.cmbTipoPer.Location = new System.Drawing.Point(209, 148);
            this.cmbTipoPer.Name = "cmbTipoPer";
            this.cmbTipoPer.Size = new System.Drawing.Size(200, 25);
            this.cmbTipoPer.TabIndex = 153;
            this.cmbTipoPer.Text = "Cliente";
            // 
            // lblShowFechaEnvio
            // 
            this.lblShowFechaEnvio.Enabled = false;
            this.lblShowFechaEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFechaEnvio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShowFechaEnvio.Location = new System.Drawing.Point(209, 59);
            this.lblShowFechaEnvio.Name = "lblShowFechaEnvio";
            this.lblShowFechaEnvio.Size = new System.Drawing.Size(153, 25);
            this.lblShowFechaEnvio.TabIndex = 154;
            this.lblShowFechaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerFechaEnvio
            // 
            this.timerFechaEnvio.Enabled = true;
            this.timerFechaEnvio.Tick += new System.EventHandler(this.timerFechaEnvio_Tick);
            // 
            // btnNuevoReg
            // 
            this.btnNuevoReg.Enabled = false;
            this.btnNuevoReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevoReg.Location = new System.Drawing.Point(436, 423);
            this.btnNuevoReg.Name = "btnNuevoReg";
            this.btnNuevoReg.Size = new System.Drawing.Size(142, 25);
            this.btnNuevoReg.TabIndex = 155;
            this.btnNuevoReg.Text = "Nuevo Registro";
            this.btnNuevoReg.UseVisualStyleBackColor = true;
            this.btnNuevoReg.Click += new System.EventHandler(this.btnNuevoReg_Click);
            // 
            // RegEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 490);
            this.Controls.Add(this.btnNuevoReg);
            this.Controls.Add(this.lblShowFechaEnvio);
            this.Controls.Add(this.cmbTipoPer);
            this.Controls.Add(this.lblValEnvio);
            this.Controls.Add(this.lblNomValEnvio);
            this.Controls.Add(this.txtDetEnvio);
            this.Controls.Add(this.lblDirUsu);
            this.Controls.Add(this.lblTelUsu);
            this.Controls.Add(this.lblCorreoUsu);
            this.Controls.Add(this.lblNomUsu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNomDes);
            this.Controls.Add(this.lblNomDes);
            this.Controls.Add(this.txtNumId);
            this.Controls.Add(this.txtNumIdDes);
            this.Controls.Add(this.lblNumIdDes);
            this.Controls.Add(this.cmbIdSucDes);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.lblTipoPer);
            this.Controls.Add(this.cmbIdSucOri);
            this.Controls.Add(this.lblIdSucOri);
            this.Controls.Add(this.cmbTipoUsu);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNumId);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDirDes);
            this.Controls.Add(this.txtTelDes);
            this.Controls.Add(this.txtNumGuia);
            this.Controls.Add(this.lblTitleReg);
            this.Controls.Add(this.lblDirDes);
            this.Controls.Add(this.lblTelDes);
            this.Controls.Add(this.lblFechaEnvio);
            this.Controls.Add(this.lblIdSucDes);
            this.Controls.Add(this.lblIdGuia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegEnvio";
            this.Text = "RegEnvio";
            this.Load += new System.EventHandler(this.RegEnvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.Label lblTipoPer;
        private System.Windows.Forms.ComboBox cmbIdSucOri;
        private System.Windows.Forms.Label lblIdSucOri;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNumId;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDirDes;
        private System.Windows.Forms.TextBox txtTelDes;
        private System.Windows.Forms.TextBox txtNumGuia;
        private System.Windows.Forms.Label lblTitleReg;
        private System.Windows.Forms.Label lblDirDes;
        private System.Windows.Forms.Label lblTelDes;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.Label lblIdSucDes;
        private System.Windows.Forms.Label lblIdGuia;
        private System.Windows.Forms.ComboBox cmbIdSucDes;
        private System.Windows.Forms.Label lblNumIdDes;
        private System.Windows.Forms.TextBox txtNumIdDes;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.TextBox txtNomDes;
        private System.Windows.Forms.Label lblNomDes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNomUsu;
        private System.Windows.Forms.Label lblCorreoUsu;
        private System.Windows.Forms.Label lblTelUsu;
        private System.Windows.Forms.Label lblDirUsu;
        private System.Windows.Forms.TextBox txtDetEnvio;
        private System.Windows.Forms.Label lblNomValEnvio;
        private System.Windows.Forms.Label lblValEnvio;
        private System.Windows.Forms.ComboBox cmbTipoUsu;
        private System.Windows.Forms.ComboBox cmbTipoPer;
        private System.Windows.Forms.Label lblShowFechaEnvio;
        private System.Windows.Forms.Timer timerFechaEnvio;
        private System.Windows.Forms.Button btnNuevoReg;
    }
}