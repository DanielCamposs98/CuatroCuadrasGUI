namespace CuatroCuadras.VentanasCrearCuenta
{
    partial class CreaCuentaV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaCuentaV1));
            this.panelAux = new System.Windows.Forms.Panel();
            this.lblMensError = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnContinuar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelAux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAux
            // 
            this.panelAux.BackColor = System.Drawing.SystemColors.Control;
            this.panelAux.Controls.Add(this.lblMensError);
            this.panelAux.Controls.Add(this.lblSexo);
            this.panelAux.Controls.Add(this.txtApellido);
            this.panelAux.Controls.Add(this.cmbSexo);
            this.panelAux.Controls.Add(this.txtNombre);
            this.panelAux.Controls.Add(this.txtUsuario);
            this.panelAux.Controls.Add(this.btnContinuar);
            this.panelAux.Controls.Add(this.pbLogo);
            this.panelAux.Location = new System.Drawing.Point(0, 32);
            this.panelAux.Name = "panelAux";
            this.panelAux.Size = new System.Drawing.Size(368, 480);
            this.panelAux.TabIndex = 0;
            // 
            // lblMensError
            // 
            this.lblMensError.AutoSize = true;
            this.lblMensError.Font = new System.Drawing.Font("Century Gothic", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblMensError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensError.Location = new System.Drawing.Point(84, 432);
            this.lblMensError.Name = "lblMensError";
            this.lblMensError.Size = new System.Drawing.Size(0, 16);
            this.lblMensError.TabIndex = 16;
            this.lblMensError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSexo.Location = new System.Drawing.Point(86, 334);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 17);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtApellido.BorderColorIdle = System.Drawing.Color.Black;
            this.txtApellido.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtApellido.BorderThickness = 2;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.isPassword = false;
            this.txtApellido.Location = new System.Drawing.Point(35, 276);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(298, 40);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(148, 332);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(138, 21);
            this.cmbSexo.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.Black;
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtNombre.BorderThickness = 2;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(35, 228);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 40);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.Black;
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtUsuario.BorderThickness = 2;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(35, 180);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(298, 40);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // btnContinuar
            // 
            this.btnContinuar.ActiveBorderThickness = 1;
            this.btnContinuar.ActiveCornerRadius = 10;
            this.btnContinuar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnContinuar.ActiveForecolor = System.Drawing.Color.White;
            this.btnContinuar.ActiveLineColor = System.Drawing.Color.Honeydew;
            this.btnContinuar.BackColor = System.Drawing.SystemColors.Control;
            this.btnContinuar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.BackgroundImage")));
            this.btnContinuar.ButtonText = "Continuar >>";
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnContinuar.IdleBorderThickness = 1;
            this.btnContinuar.IdleCornerRadius = 10;
            this.btnContinuar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnContinuar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnContinuar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnContinuar.Location = new System.Drawing.Point(87, 359);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(5);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(189, 48);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras_Logo_V_Black;
            this.pbLogo.Location = new System.Drawing.Point(72, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(224, 128);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CuatroCuadras.Properties.Resources.Close_icon_White;
            this.btnCerrar.Location = new System.Drawing.Point(333, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Creación de Cuentas";
            // 
            // CreaCuentaV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(365, 511);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelAux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreaCuentaV1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUno";
            this.Load += new System.EventHandler(this.CreaCuentaV1_Load);
            this.panelAux.ResumeLayout(false);
            this.panelAux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAux;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContinuar;
        private System.Windows.Forms.Label lblMensError;
    }
}