namespace CuatroCuadras.VentanasComplementarias
{
    partial class VentanaAmigos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dgAmigos = new System.Windows.Forms.DataGridView();
            this.dgSugerencias = new System.Windows.Forms.DataGridView();
            this.dgSolicitudes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarPerfil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAmigosComun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NicknameSug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NicknameSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarSol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRechazarSol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSugerencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amigos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Amigos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(469, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sugerencias";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(453, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 425);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // dgAmigos
            // 
            this.dgAmigos.AllowUserToAddRows = false;
            this.dgAmigos.AllowUserToDeleteRows = false;
            this.dgAmigos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.dgAmigos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAmigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nickname,
            this.Nombre,
            this.Ciudad,
            this.btnMostrarPerfil,
            this.btnAmigosComun});
            this.dgAmigos.Location = new System.Drawing.Point(45, 129);
            this.dgAmigos.Name = "dgAmigos";
            this.dgAmigos.ReadOnly = true;
            this.dgAmigos.RowHeadersVisible = false;
            this.dgAmigos.Size = new System.Drawing.Size(402, 357);
            this.dgAmigos.TabIndex = 5;
            this.dgAmigos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAmigos_CellClick);
            // 
            // dgSugerencias
            // 
            this.dgSugerencias.AllowUserToAddRows = false;
            this.dgSugerencias.AllowUserToDeleteRows = false;
            this.dgSugerencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.dgSugerencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSugerencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NicknameSug,
            this.btnAgregar});
            this.dgSugerencias.Location = new System.Drawing.Point(473, 129);
            this.dgSugerencias.Name = "dgSugerencias";
            this.dgSugerencias.ReadOnly = true;
            this.dgSugerencias.RowHeadersVisible = false;
            this.dgSugerencias.Size = new System.Drawing.Size(299, 154);
            this.dgSugerencias.TabIndex = 6;
            this.dgSugerencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSugerencias_CellClick);
            // 
            // dgSolicitudes
            // 
            this.dgSolicitudes.AllowUserToAddRows = false;
            this.dgSolicitudes.AllowUserToDeleteRows = false;
            this.dgSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.dgSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NicknameSol,
            this.btnAceptarSol,
            this.btnRechazarSol});
            this.dgSolicitudes.Location = new System.Drawing.Point(473, 332);
            this.dgSolicitudes.Name = "dgSolicitudes";
            this.dgSolicitudes.ReadOnly = true;
            this.dgSolicitudes.RowHeadersVisible = false;
            this.dgSolicitudes.Size = new System.Drawing.Size(300, 154);
            this.dgSolicitudes.TabIndex = 8;
            this.dgSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSolicitudes_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(469, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Solicitudes";
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // btnMostrarPerfil
            // 
            this.btnMostrarPerfil.HeaderText = "Perfil";
            this.btnMostrarPerfil.Name = "btnMostrarPerfil";
            this.btnMostrarPerfil.ReadOnly = true;
            this.btnMostrarPerfil.Text = "Mostrar";
            this.btnMostrarPerfil.UseColumnTextForButtonValue = true;
            this.btnMostrarPerfil.Width = 40;
            // 
            // btnAmigosComun
            // 
            this.btnAmigosComun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnAmigosComun.HeaderText = " Amigos Común";
            this.btnAmigosComun.Name = "btnAmigosComun";
            this.btnAmigosComun.ReadOnly = true;
            this.btnAmigosComun.Text = "Mostrar";
            this.btnAmigosComun.UseColumnTextForButtonValue = true;
            // 
            // NicknameSug
            // 
            this.NicknameSug.HeaderText = "Nickname";
            this.NicknameSug.Name = "NicknameSug";
            this.NicknameSug.ReadOnly = true;
            this.NicknameSug.Width = 200;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnAgregar.HeaderText = " ";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ReadOnly = true;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseColumnTextForButtonValue = true;
            // 
            // NicknameSol
            // 
            this.NicknameSol.HeaderText = "Nickname";
            this.NicknameSol.Name = "NicknameSol";
            this.NicknameSol.ReadOnly = true;
            this.NicknameSol.Width = 150;
            // 
            // btnAceptarSol
            // 
            this.btnAceptarSol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarSol.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnAceptarSol.HeaderText = "";
            this.btnAceptarSol.Name = "btnAceptarSol";
            this.btnAceptarSol.ReadOnly = true;
            this.btnAceptarSol.Text = "Aceptar";
            this.btnAceptarSol.UseColumnTextForButtonValue = true;
            this.btnAceptarSol.Width = 75;
            // 
            // btnRechazarSol
            // 
            this.btnRechazarSol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnRechazarSol.HeaderText = " ";
            this.btnRechazarSol.Name = "btnRechazarSol";
            this.btnRechazarSol.ReadOnly = true;
            this.btnRechazarSol.Text = "Rechazar";
            this.btnRechazarSol.UseColumnTextForButtonValue = true;
            // 
            // VentanaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.dgSolicitudes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgSugerencias);
            this.Controls.Add(this.dgAmigos);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaAmigos";
            this.Text = "VentanaAmigos";
            this.Load += new System.EventHandler(this.VentanaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSugerencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridView dgAmigos;
        private System.Windows.Forms.DataGridView dgSugerencias;
        private System.Windows.Forms.DataGridView dgSolicitudes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewButtonColumn btnMostrarPerfil;
        private System.Windows.Forms.DataGridViewButtonColumn btnAmigosComun;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameSug;
        private System.Windows.Forms.DataGridViewButtonColumn btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameSol;
        private System.Windows.Forms.DataGridViewButtonColumn btnAceptarSol;
        private System.Windows.Forms.DataGridViewButtonColumn btnRechazarSol;
    }
}