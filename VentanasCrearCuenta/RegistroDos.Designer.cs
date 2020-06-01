namespace CuatroCuadras.VentanasCrearCuenta
{
    partial class CreaCuentaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaCuentaV2));
            this.panelAux = new System.Windows.Forms.Panel();
            this.lblMensError = new System.Windows.Forms.Label();
            this.dpFechaNac = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtRepCont = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCrear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelAux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAux
            // 
            this.panelAux.BackColor = System.Drawing.SystemColors.Control;
            this.panelAux.Controls.Add(this.lblMensError);
            this.panelAux.Controls.Add(this.dpFechaNac);
            this.panelAux.Controls.Add(this.lblCiudad);
            this.panelAux.Controls.Add(this.cmbCiudad);
            this.panelAux.Controls.Add(this.txtRepCont);
            this.panelAux.Controls.Add(this.txtContraseña);
            this.panelAux.Controls.Add(this.txtCorreo);
            this.panelAux.Controls.Add(this.btnCrear);
            this.panelAux.Controls.Add(this.pbLogo);
            this.panelAux.Location = new System.Drawing.Point(0, 32);
            this.panelAux.Name = "panelAux";
            this.panelAux.Size = new System.Drawing.Size(368, 480);
            this.panelAux.TabIndex = 1;
            // 
            // lblMensError
            // 
            this.lblMensError.AutoSize = true;
            this.lblMensError.Font = new System.Drawing.Font("Century Gothic", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblMensError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensError.Location = new System.Drawing.Point(88, 446);
            this.lblMensError.Name = "lblMensError";
            this.lblMensError.Size = new System.Drawing.Size(0, 16);
            this.lblMensError.TabIndex = 17;
            this.lblMensError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpFechaNac
            // 
            this.dpFechaNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dpFechaNac.BorderRadius = 0;
            this.dpFechaNac.ForeColor = System.Drawing.Color.White;
            this.dpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpFechaNac.FormatCustom = null;
            this.dpFechaNac.Location = new System.Drawing.Point(35, 339);
            this.dpFechaNac.Name = "dpFechaNac";
            this.dpFechaNac.Size = new System.Drawing.Size(298, 40);
            this.dpFechaNac.TabIndex = 15;
            this.dpFechaNac.Value = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCiudad.Location = new System.Drawing.Point(82, 165);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(61, 17);
            this.lblCiudad.TabIndex = 14;
            this.lblCiudad.Text = "Ciudad:";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(153, 163);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(138, 21);
            this.cmbCiudad.TabIndex = 11;
            // 
            // txtRepCont
            // 
            this.txtRepCont.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtRepCont.BorderColorIdle = System.Drawing.Color.Black;
            this.txtRepCont.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtRepCont.BorderThickness = 2;
            this.txtRepCont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepCont.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepCont.isPassword = false;
            this.txtRepCont.Location = new System.Drawing.Point(35, 292);
            this.txtRepCont.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepCont.Name = "txtRepCont";
            this.txtRepCont.Size = new System.Drawing.Size(298, 40);
            this.txtRepCont.TabIndex = 10;
            this.txtRepCont.Text = "Repite Contraseña";
            this.txtRepCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepCont.Enter += new System.EventHandler(this.txtRepCont_Enter);
            this.txtRepCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaR_KeyPress);
            this.txtRepCont.Leave += new System.EventHandler(this.txtRepCont_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.Black;
            this.txtContraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtContraseña.BorderThickness = 2;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.isPassword = false;
            this.txtContraseña.Location = new System.Drawing.Point(35, 244);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(298, 40);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtCorreo.BorderColorIdle = System.Drawing.Color.Black;
            this.txtCorreo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtCorreo.BorderThickness = 2;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.isPassword = false;
            this.txtCorreo.Location = new System.Drawing.Point(35, 196);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(298, 40);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // btnCrear
            // 
            this.btnCrear.ActiveBorderThickness = 1;
            this.btnCrear.ActiveCornerRadius = 10;
            this.btnCrear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCrear.ActiveForecolor = System.Drawing.Color.White;
            this.btnCrear.ActiveLineColor = System.Drawing.Color.Honeydew;
            this.btnCrear.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.ButtonText = "Crear Cuenta";
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCrear.IdleBorderThickness = 1;
            this.btnCrear.IdleCornerRadius = 10;
            this.btnCrear.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCrear.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCrear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCrear.Location = new System.Drawing.Point(85, 387);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(189, 48);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras_Logo_V_Black;
            this.pbLogo.Location = new System.Drawing.Point(72, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(224, 128);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 19);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Creación de Cuentas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(333, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CreaCuentaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(365, 511);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelAux);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreaCuentaV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDos";
            this.Load += new System.EventHandler(this.CreaCuentaV2_Load);
            this.panelAux.ResumeLayout(false);
            this.panelAux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAux;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRepCont;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCrear;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private Bunifu.Framework.UI.BunifuDatepicker dpFechaNac;
        private System.Windows.Forms.Label lblMensError;
    }
}