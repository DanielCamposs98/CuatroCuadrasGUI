namespace CuatroCuadras.VentanasComplementarias
{
    partial class VentanaLugares
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
            this.dgLugares = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgLugaresVisitados = new System.Windows.Forms.DataGridView();
            this.nombreVisitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoracionVis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarVisitado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLugaresVisitados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lugares";
            // 
            // dgLugares
            // 
            this.dgLugares.AllowUserToAddRows = false;
            this.dgLugares.AllowUserToDeleteRows = false;
            this.dgLugares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.dgLugares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLugares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Ciudad,
            this.btnMostrar});
            this.dgLugares.Location = new System.Drawing.Point(35, 123);
            this.dgLugares.Name = "dgLugares";
            this.dgLugares.ReadOnly = true;
            this.dgLugares.RowHeadersVisible = false;
            this.dgLugares.Size = new System.Drawing.Size(374, 333);
            this.dgLugares.TabIndex = 3;
            this.dgLugares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.muestraLugarDG);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnMostrar.HeaderText = "Accion";
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.ReadOnly = true;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseColumnTextForButtonValue = true;
            // 
            // dgLugaresVisitados
            // 
            this.dgLugaresVisitados.AllowUserToAddRows = false;
            this.dgLugaresVisitados.AllowUserToDeleteRows = false;
            this.dgLugaresVisitados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.dgLugaresVisitados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLugaresVisitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLugaresVisitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreVisitado,
            this.ValoracionVis,
            this.Comentario,
            this.btnMostrarVisitado});
            this.dgLugaresVisitados.Location = new System.Drawing.Point(440, 123);
            this.dgLugaresVisitados.Name = "dgLugaresVisitados";
            this.dgLugaresVisitados.ReadOnly = true;
            this.dgLugaresVisitados.RowHeadersVisible = false;
            this.dgLugaresVisitados.Size = new System.Drawing.Size(341, 250);
            this.dgLugaresVisitados.TabIndex = 4;
            this.dgLugaresVisitados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLugaresVisitados_CellClick);
            // 
            // nombreVisitado
            // 
            this.nombreVisitado.HeaderText = "Nombre";
            this.nombreVisitado.Name = "nombreVisitado";
            this.nombreVisitado.ReadOnly = true;
            // 
            // ValoracionVis
            // 
            this.ValoracionVis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValoracionVis.HeaderText = "Valoracion";
            this.ValoracionVis.Name = "ValoracionVis";
            this.ValoracionVis.ReadOnly = true;
            this.ValoracionVis.Width = 70;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            // 
            // btnMostrarVisitado
            // 
            this.btnMostrarVisitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnMostrarVisitado.HeaderText = " Accion";
            this.btnMostrarVisitado.Name = "btnMostrarVisitado";
            this.btnMostrarVisitado.ReadOnly = true;
            this.btnMostrarVisitado.Text = "Mostrar";
            this.btnMostrarVisitado.UseColumnTextForButtonValue = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(421, 105);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(13, 395);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Lugares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(440, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lugares Visitados";
            // 
            // VentanaLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dgLugaresVisitados);
            this.Controls.Add(this.dgLugares);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaLugares";
            this.Text = "VentanaLugares";
            this.Load += new System.EventHandler(this.VentanaLugares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLugaresVisitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLugares;
        private System.Windows.Forms.DataGridView dgLugaresVisitados;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewButtonColumn btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVisitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoracionVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewButtonColumn btnMostrarVisitado;
    }
}