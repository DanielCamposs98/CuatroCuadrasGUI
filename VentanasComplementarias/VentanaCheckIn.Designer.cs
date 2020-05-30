namespace CuatroCuadras.VentanasComplementarias
{
    partial class VentanaCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCheckIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpValoracion = new System.Windows.Forms.NumericUpDown();
            this.cmbLugares = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnRegistrarCI = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check-In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(88, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lugar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(41, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentario :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(50, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valoración :";
            // 
            // numUpValoracion
            // 
            this.numUpValoracion.BackColor = System.Drawing.SystemColors.Control;
            this.numUpValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpValoracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numUpValoracion.Location = new System.Drawing.Point(176, 357);
            this.numUpValoracion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpValoracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpValoracion.Name = "numUpValoracion";
            this.numUpValoracion.ReadOnly = true;
            this.numUpValoracion.Size = new System.Drawing.Size(120, 23);
            this.numUpValoracion.TabIndex = 6;
            this.numUpValoracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpValoracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbLugares
            // 
            this.cmbLugares.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.Location = new System.Drawing.Point(176, 116);
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(276, 24);
            this.cmbLugares.TabIndex = 7;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentario.Location = new System.Drawing.Point(176, 164);
            this.txtComentario.MaxLength = 50;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(276, 166);
            this.txtComentario.TabIndex = 8;
            // 
            // btnRegistrarCI
            // 
            this.btnRegistrarCI.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarCI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarCI.BorderRadius = 0;
            this.btnRegistrarCI.ButtonText = "Registrar Check-In";
            this.btnRegistrarCI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCI.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrarCI.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrarCI.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCI.Iconimage")));
            this.btnRegistrarCI.Iconimage_right = null;
            this.btnRegistrarCI.Iconimage_right_Selected = null;
            this.btnRegistrarCI.Iconimage_Selected = null;
            this.btnRegistrarCI.IconMarginLeft = 30;
            this.btnRegistrarCI.IconMarginRight = 0;
            this.btnRegistrarCI.IconRightVisible = true;
            this.btnRegistrarCI.IconRightZoom = 0D;
            this.btnRegistrarCI.IconVisible = true;
            this.btnRegistrarCI.IconZoom = 130D;
            this.btnRegistrarCI.IsTab = false;
            this.btnRegistrarCI.Location = new System.Drawing.Point(176, 436);
            this.btnRegistrarCI.Name = "btnRegistrarCI";
            this.btnRegistrarCI.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarCI.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegistrarCI.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrarCI.selected = false;
            this.btnRegistrarCI.Size = new System.Drawing.Size(276, 48);
            this.btnRegistrarCI.TabIndex = 9;
            this.btnRegistrarCI.Text = "Registrar Check-In";
            this.btnRegistrarCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarCI.Textcolor = System.Drawing.Color.White;
            this.btnRegistrarCI.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCI.Click += new System.EventHandler(this.btnRegistrarCI_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CuatroCuadras.Properties.Resources.Close_icon_White;
            this.btnCerrar.Location = new System.Drawing.Point(447, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VentanaCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(507, 518);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrarCI);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.cmbLugares);
            this.Controls.Add(this.numUpValoracion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaCheckIn";
            this.Text = "VentanaCheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.numUpValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpValoracion;
        private System.Windows.Forms.ComboBox cmbLugares;
        private System.Windows.Forms.TextBox txtComentario;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrarCI;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}