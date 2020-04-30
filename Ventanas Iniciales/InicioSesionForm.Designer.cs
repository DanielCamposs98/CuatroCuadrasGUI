namespace CuatroCuadras
{
    partial class InicioSesionForm
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
            this.barra1 = new System.Windows.Forms.Label();
            this.barra2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lkFPass = new System.Windows.Forms.LinkLabel();
            this.panInicio = new System.Windows.Forms.Panel();
            this.lblMensError = new System.Windows.Forms.Label();
            this.lkCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.btnIniciaSesion = new System.Windows.Forms.Button();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.AutoSize = true;
            this.barra1.Location = new System.Drawing.Point(42, 80);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(391, 13);
            this.barra1.TabIndex = 1;
            this.barra1.Text = "________________________________________________________________";
            // 
            // barra2
            // 
            this.barra2.AutoSize = true;
            this.barra2.Location = new System.Drawing.Point(42, 127);
            this.barra2.Name = "barra2";
            this.barra2.Size = new System.Drawing.Size(391, 13);
            this.barra2.TabIndex = 2;
            this.barra2.Text = "________________________________________________________________";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(45, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(388, 17);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(45, 120);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(357, 17);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lkFPass
            // 
            this.lkFPass.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lkFPass.AutoSize = true;
            this.lkFPass.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lkFPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lkFPass.Location = new System.Drawing.Point(280, 166);
            this.lkFPass.Name = "lkFPass";
            this.lkFPass.Size = new System.Drawing.Size(153, 16);
            this.lkFPass.TabIndex = 5;
            this.lkFPass.TabStop = true;
            this.lkFPass.Text = "¿Olvidaste la contraseña?";
            // 
            // panInicio
            // 
            this.panInicio.Controls.Add(this.lblMensError);
            this.panInicio.Controls.Add(this.pbEye);
            this.panInicio.Controls.Add(this.lkCrearCuenta);
            this.panInicio.Controls.Add(this.pbClose);
            this.panInicio.Controls.Add(this.btnIniciaSesion);
            this.panInicio.Controls.Add(this.lkFPass);
            this.panInicio.Controls.Add(this.txtPass);
            this.panInicio.Controls.Add(this.txtUsuario);
            this.panInicio.Controls.Add(this.barra2);
            this.panInicio.Controls.Add(this.barra1);
            this.panInicio.Location = new System.Drawing.Point(237, 0);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(464, 254);
            this.panInicio.TabIndex = 6;
            this.panInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panInicio_MouseDown);
            // 
            // lblMensError
            // 
            this.lblMensError.AutoSize = true;
            this.lblMensError.Font = new System.Drawing.Font("Century Gothic", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblMensError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensError.Location = new System.Drawing.Point(42, 205);
            this.lblMensError.Name = "lblMensError";
            this.lblMensError.Size = new System.Drawing.Size(0, 16);
            this.lblMensError.TabIndex = 10;
            this.lblMensError.Visible = false;
            // 
            // lkCrearCuenta
            // 
            this.lkCrearCuenta.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.lkCrearCuenta.AutoSize = true;
            this.lkCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lkCrearCuenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lkCrearCuenta.Location = new System.Drawing.Point(42, 166);
            this.lkCrearCuenta.Name = "lkCrearCuenta";
            this.lkCrearCuenta.Size = new System.Drawing.Size(83, 16);
            this.lkCrearCuenta.TabIndex = 8;
            this.lkCrearCuenta.TabStop = true;
            this.lkCrearCuenta.Text = "Crear Cuenta";
            this.lkCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCrearCuenta_LinkClicked);
            // 
            // btnIniciaSesion
            // 
            this.btnIniciaSesion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIniciaSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIniciaSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIniciaSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciaSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaSesion.Location = new System.Drawing.Point(283, 194);
            this.btnIniciaSesion.Name = "btnIniciaSesion";
            this.btnIniciaSesion.Size = new System.Drawing.Size(150, 34);
            this.btnIniciaSesion.TabIndex = 6;
            this.btnIniciaSesion.Text = "Iniciar Sesión";
            this.btnIniciaSesion.UseVisualStyleBackColor = true;
            this.btnIniciaSesion.Click += new System.EventHandler(this.btnIniciaSesion_Click);
            // 
            // pbEye
            // 
            this.pbEye.Image = global::CuatroCuadras.Properties.Resources.Eye_icon;
            this.pbEye.Location = new System.Drawing.Point(408, 117);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(20, 20);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEye.TabIndex = 9;
            this.pbEye.TabStop = false;
            this.pbEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbEye_MouseDown);
            this.pbEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbEye_MouseUp);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::CuatroCuadras.Properties.Resources.Close_icon;
            this.pbClose.Location = new System.Drawing.Point(431, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbLogo.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras_LogoV;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(240, 256);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 250);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesionForm";
            this.panInicio.ResumeLayout(false);
            this.panInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label barra1;
        private System.Windows.Forms.Label barra2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel lkFPass;
        private System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.Button btnIniciaSesion;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.LinkLabel lkCrearCuenta;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.Label lblMensError;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}