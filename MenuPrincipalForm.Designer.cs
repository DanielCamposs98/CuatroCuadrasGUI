namespace CuatroCuadras
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.MenuBarPane = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BarraSuperiorPane = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogoCC = new System.Windows.Forms.PictureBox();
            this.BienvenidaPane = new System.Windows.Forms.Panel();
            this.lblBienvenida = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MenuBarPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraSuperiorPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCC)).BeginInit();
            this.BienvenidaPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBarPane
            // 
            this.MenuBarPane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuBarPane.BackgroundImage")));
            this.MenuBarPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBarPane.Controls.Add(this.btnCerrarSesion);
            this.MenuBarPane.Controls.Add(this.pictureBox2);
            this.MenuBarPane.GradientBottomLeft = System.Drawing.Color.Silver;
            this.MenuBarPane.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuBarPane.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuBarPane.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuBarPane.Location = new System.Drawing.Point(0, 48);
            this.MenuBarPane.Name = "MenuBarPane";
            this.MenuBarPane.Quality = 10;
            this.MenuBarPane.Size = new System.Drawing.Size(48, 552);
            this.MenuBarPane.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(8, 512);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 504);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // BarraSuperiorPane
            // 
            this.BarraSuperiorPane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraSuperiorPane.BackgroundImage")));
            this.BarraSuperiorPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarraSuperiorPane.Controls.Add(this.btnMinimizar);
            this.BarraSuperiorPane.Controls.Add(this.btnCerrar);
            this.BarraSuperiorPane.Controls.Add(this.pbLogoCC);
            this.BarraSuperiorPane.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BarraSuperiorPane.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BarraSuperiorPane.GradientTopLeft = System.Drawing.Color.Silver;
            this.BarraSuperiorPane.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BarraSuperiorPane.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorPane.Name = "BarraSuperiorPane";
            this.BarraSuperiorPane.Quality = 10;
            this.BarraSuperiorPane.Size = new System.Drawing.Size(1000, 48);
            this.BarraSuperiorPane.TabIndex = 3;
            this.BarraSuperiorPane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperiorPane_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(928, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(960, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbLogoCC
            // 
            this.pbLogoCC.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoCC.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras_LogoH;
            this.pbLogoCC.Location = new System.Drawing.Point(16, -8);
            this.pbLogoCC.Name = "pbLogoCC";
            this.pbLogoCC.Size = new System.Drawing.Size(136, 64);
            this.pbLogoCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoCC.TabIndex = 0;
            this.pbLogoCC.TabStop = false;
            // 
            // BienvenidaPane
            // 
            this.BienvenidaPane.BackColor = System.Drawing.Color.Lavender;
            this.BienvenidaPane.Controls.Add(this.lblBienvenida);
            this.BienvenidaPane.Location = new System.Drawing.Point(48, 48);
            this.BienvenidaPane.Name = "BienvenidaPane";
            this.BienvenidaPane.Size = new System.Drawing.Size(952, 48);
            this.BienvenidaPane.TabIndex = 5;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblBienvenida.Location = new System.Drawing.Point(24, 8);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 30);
            this.lblBienvenida.TabIndex = 0;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.BienvenidaPane);
            this.Controls.Add(this.MenuBarPane);
            this.Controls.Add(this.BarraSuperiorPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.MenuBarPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraSuperiorPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCC)).EndInit();
            this.BienvenidaPane.ResumeLayout(false);
            this.BienvenidaPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel BarraSuperiorPane;
        private System.Windows.Forms.PictureBox pbLogoCC;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuBarPane;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BienvenidaPane;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBienvenida;
    }
}