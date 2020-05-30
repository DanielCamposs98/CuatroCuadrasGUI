namespace CuatroCuadras.Ventanas_Iniciales
{
    partial class BienvenidaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienvenidaForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.lblIS = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCiudad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // barraProgreso
            // 
            this.barraProgreso.ForeColor = System.Drawing.SystemColors.Desktop;
            this.barraProgreso.Location = new System.Drawing.Point(111, 272);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(306, 23);
            this.barraProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgreso.TabIndex = 2;
            // 
            // lblIS
            // 
            this.lblIS.AutoSize = true;
            this.lblIS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIS.Location = new System.Drawing.Point(179, 219);
            this.lblIS.Name = "lblIS";
            this.lblIS.Size = new System.Drawing.Size(170, 22);
            this.lblIS.TabIndex = 3;
            this.lblIS.Text = "Iniciando Sesión...";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CuatroCuadras.Properties.Resources.CuatroCuadras_LogoH;
            this.pbLogo.Location = new System.Drawing.Point(71, 42);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(386, 146);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbCiudad
            // 
            this.pbCiudad.Image = global::CuatroCuadras.Properties.Resources.Night_City;
            this.pbCiudad.Location = new System.Drawing.Point(513, 2);
            this.pbCiudad.Name = "pbCiudad";
            this.pbCiudad.Size = new System.Drawing.Size(306, 402);
            this.pbCiudad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCiudad.TabIndex = 0;
            this.pbCiudad.TabStop = false;
            // 
            // BienvenidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblIS);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BienvenidaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciando Cuatro Cuadras";
            this.Load += new System.EventHandler(this.BienvenidaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCiudad;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Label lblIS;
    }
}