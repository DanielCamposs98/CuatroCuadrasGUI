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
            this.panLogo = new System.Windows.Forms.Panel();
            this.barra1 = new System.Windows.Forms.Label();
            this.barra2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lkFPass = new System.Windows.Forms.LinkLabel();
            this.panInicio = new System.Windows.Forms.Panel();
            this.btnIniciaSesion = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panLogo.SuspendLayout();
            this.panInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panLogo.Controls.Add(this.Logo);
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(241, 255);
            this.panLogo.TabIndex = 0;
            // 
            // barra1
            // 
            this.barra1.AutoSize = true;
            this.barra1.Location = new System.Drawing.Point(40, 90);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(391, 13);
            this.barra1.TabIndex = 1;
            this.barra1.Text = "________________________________________________________________";
            // 
            // barra2
            // 
            this.barra2.AutoSize = true;
            this.barra2.Location = new System.Drawing.Point(40, 137);
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
            this.txtUsuario.Location = new System.Drawing.Point(43, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(388, 17);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(43, 129);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(388, 17);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "CONTRASEÑA";
            // 
            // lkFPass
            // 
            this.lkFPass.AutoSize = true;
            this.lkFPass.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lkFPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lkFPass.Location = new System.Drawing.Point(156, 224);
            this.lkFPass.Name = "lkFPass";
            this.lkFPass.Size = new System.Drawing.Size(153, 16);
            this.lkFPass.TabIndex = 5;
            this.lkFPass.TabStop = true;
            this.lkFPass.Text = "¿Olvidaste la contraseña?";
            // 
            // panInicio
            // 
            this.panInicio.Controls.Add(this.Close);
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
            // 
            // btnIniciaSesion
            // 
            this.btnIniciaSesion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIniciaSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIniciaSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIniciaSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciaSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaSesion.Location = new System.Drawing.Point(157, 168);
            this.btnIniciaSesion.Name = "btnIniciaSesion";
            this.btnIniciaSesion.Size = new System.Drawing.Size(150, 34);
            this.btnIniciaSesion.TabIndex = 6;
            this.btnIniciaSesion.Text = "Iniciar Sesión";
            this.btnIniciaSesion.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras__1_;
            this.Logo.Location = new System.Drawing.Point(20, 62);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 130);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Close
            // 
            this.Close.Image = global::CuatroCuadras.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(431, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 7;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 250);
            this.Controls.Add(this.panLogo);
            this.Controls.Add(this.panInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesionForm";
            this.panLogo.ResumeLayout(false);
            this.panInicio.ResumeLayout(false);
            this.panInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label barra1;
        private System.Windows.Forms.Label barra2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel lkFPass;
        private System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.Button btnIniciaSesion;
        private System.Windows.Forms.PictureBox Close;
    }
}