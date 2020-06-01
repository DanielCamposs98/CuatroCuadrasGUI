namespace CuatroCuadras.VentanasComplementarias
{
    partial class VentanaMuestraLugar
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
            this.lblNombreLugar = new System.Windows.Forms.Label();
            this.staticLat = new System.Windows.Forms.Label();
            this.staticLong = new System.Windows.Forms.Label();
            this.staticCat = new System.Windows.Forms.Label();
            this.staticEtiq = new System.Windows.Forms.Label();
            this.staticCiudad = new System.Windows.Forms.Label();
            this.staticDesc = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.sepH2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepH1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dgVisitas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratLugar = new Bunifu.Framework.UI.BunifuRating();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.mapaLugar = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreLugar
            // 
            this.lblNombreLugar.AutoSize = true;
            this.lblNombreLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreLugar.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreLugar.Location = new System.Drawing.Point(34, 32);
            this.lblNombreLugar.Name = "lblNombreLugar";
            this.lblNombreLugar.Size = new System.Drawing.Size(0, 34);
            this.lblNombreLugar.TabIndex = 0;
            this.lblNombreLugar.UseCompatibleTextRendering = true;
            // 
            // staticLat
            // 
            this.staticLat.AutoSize = true;
            this.staticLat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLat.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticLat.Location = new System.Drawing.Point(35, 81);
            this.staticLat.Name = "staticLat";
            this.staticLat.Size = new System.Drawing.Size(20, 17);
            this.staticLat.TabIndex = 2;
            this.staticLat.Text = "Lat.";
            this.staticLat.UseCompatibleTextRendering = true;
            // 
            // staticLong
            // 
            this.staticLong.AutoSize = true;
            this.staticLong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLong.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticLong.Location = new System.Drawing.Point(173, 81);
            this.staticLong.Name = "staticLong";
            this.staticLong.Size = new System.Drawing.Size(29, 17);
            this.staticLong.TabIndex = 3;
            this.staticLong.Text = "Long.";
            this.staticLong.UseCompatibleTextRendering = true;
            // 
            // staticCat
            // 
            this.staticCat.AutoSize = true;
            this.staticCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticCat.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticCat.Location = new System.Drawing.Point(35, 114);
            this.staticCat.Name = "staticCat";
            this.staticCat.Size = new System.Drawing.Size(59, 19);
            this.staticCat.TabIndex = 4;
            this.staticCat.Text = "Categoria:";
            this.staticCat.UseCompatibleTextRendering = true;
            // 
            // staticEtiq
            // 
            this.staticEtiq.AutoSize = true;
            this.staticEtiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticEtiq.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticEtiq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticEtiq.Location = new System.Drawing.Point(331, 114);
            this.staticEtiq.Name = "staticEtiq";
            this.staticEtiq.Size = new System.Drawing.Size(52, 19);
            this.staticEtiq.TabIndex = 5;
            this.staticEtiq.Text = "Etiqueta:";
            this.staticEtiq.UseCompatibleTextRendering = true;
            // 
            // staticCiudad
            // 
            this.staticCiudad.AutoSize = true;
            this.staticCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticCiudad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticCiudad.Location = new System.Drawing.Point(331, 81);
            this.staticCiudad.Name = "staticCiudad";
            this.staticCiudad.Size = new System.Drawing.Size(45, 19);
            this.staticCiudad.TabIndex = 6;
            this.staticCiudad.Text = "Ciudad:";
            this.staticCiudad.UseCompatibleTextRendering = true;
            // 
            // staticDesc
            // 
            this.staticDesc.AutoSize = true;
            this.staticDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staticDesc.Location = new System.Drawing.Point(35, 158);
            this.staticDesc.Name = "staticDesc";
            this.staticDesc.Size = new System.Drawing.Size(70, 19);
            this.staticDesc.TabIndex = 7;
            this.staticDesc.Text = "Descripción:";
            this.staticDesc.UseCompatibleTextRendering = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescripcion.Location = new System.Drawing.Point(112, 158);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(362, 50);
            this.txtDescripcion.TabIndex = 8;
            // 
            // sepH2
            // 
            this.sepH2.BackColor = System.Drawing.Color.Transparent;
            this.sepH2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sepH2.LineThickness = 1;
            this.sepH2.Location = new System.Drawing.Point(35, 236);
            this.sepH2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sepH2.Name = "sepH2";
            this.sepH2.Size = new System.Drawing.Size(439, 12);
            this.sepH2.TabIndex = 9;
            this.sepH2.Transparency = 255;
            this.sepH2.Vertical = false;
            // 
            // sepH1
            // 
            this.sepH1.BackColor = System.Drawing.Color.Transparent;
            this.sepH1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sepH1.LineThickness = 1;
            this.sepH1.Location = new System.Drawing.Point(35, 65);
            this.sepH1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sepH1.Name = "sepH1";
            this.sepH1.Size = new System.Drawing.Size(439, 12);
            this.sepH1.TabIndex = 10;
            this.sepH1.Transparency = 255;
            this.sepH1.Vertical = false;
            // 
            // dgVisitas
            // 
            this.dgVisitas.AllowUserToAddRows = false;
            this.dgVisitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.dgVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVisitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgVisitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVisitas.ColumnHeadersHeight = 25;
            this.dgVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.valoracion,
            this.comentario});
            this.dgVisitas.DoubleBuffered = true;
            this.dgVisitas.EnableHeadersVisualStyles = false;
            this.dgVisitas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisitas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgVisitas.HeaderForeColor = System.Drawing.SystemColors.ControlLight;
            this.dgVisitas.Location = new System.Drawing.Point(34, 257);
            this.dgVisitas.MultiSelect = false;
            this.dgVisitas.Name = "dgVisitas";
            this.dgVisitas.ReadOnly = true;
            this.dgVisitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVisitas.RowTemplate.Height = 25;
            this.dgVisitas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisitas.Size = new System.Drawing.Size(439, 249);
            this.dgVisitas.TabIndex = 11;
            // 
            // user
            // 
            this.user.FillWeight = 60.9137F;
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // valoracion
            // 
            this.valoracion.FillWeight = 119.5432F;
            this.valoracion.HeaderText = "Valoración";
            this.valoracion.Name = "valoracion";
            this.valoracion.ReadOnly = true;
            // 
            // comentario
            // 
            this.comentario.FillWeight = 119.5432F;
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            this.comentario.ReadOnly = true;
            // 
            // ratLugar
            // 
            this.ratLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ratLugar.BackColor = System.Drawing.Color.Transparent;
            this.ratLugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ratLugar.Enabled = false;
            this.ratLugar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratLugar.ForeColor = System.Drawing.Color.Goldenrod;
            this.ratLugar.Location = new System.Drawing.Point(489, 65);
            this.ratLugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ratLugar.Name = "ratLugar";
            this.ratLugar.Size = new System.Drawing.Size(193, 33);
            this.ratLugar.TabIndex = 12;
            this.ratLugar.Value = 0;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("League Spartan", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCalificacion.Location = new System.Drawing.Point(499, 114);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(0, 44);
            this.lblCalificacion.TabIndex = 14;
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLatitud.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLatitud.Location = new System.Drawing.Point(60, 81);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(0, 19);
            this.lblLatitud.TabIndex = 15;
            this.lblLatitud.UseCompatibleTextRendering = true;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLongitud.Location = new System.Drawing.Point(207, 81);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(0, 19);
            this.lblLongitud.TabIndex = 19;
            this.lblLongitud.UseCompatibleTextRendering = true;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCiudad.Location = new System.Drawing.Point(382, 81);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(0, 19);
            this.lblCiudad.TabIndex = 20;
            this.lblCiudad.UseCompatibleTextRendering = true;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEtiqueta.Location = new System.Drawing.Point(382, 114);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(0, 19);
            this.lblEtiqueta.TabIndex = 21;
            this.lblEtiqueta.UseCompatibleTextRendering = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoria.Location = new System.Drawing.Point(98, 114);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 19);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.UseCompatibleTextRendering = true;
            // 
            // mapaLugar
            // 
            this.mapaLugar.Bearing = 0F;
            this.mapaLugar.CanDragMap = true;
            this.mapaLugar.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaLugar.GrayScaleMode = false;
            this.mapaLugar.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaLugar.LevelsKeepInMemmory = 5;
            this.mapaLugar.Location = new System.Drawing.Point(489, 257);
            this.mapaLugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mapaLugar.MarkersEnabled = true;
            this.mapaLugar.MaxZoom = 2;
            this.mapaLugar.MinZoom = 2;
            this.mapaLugar.MouseWheelZoomEnabled = true;
            this.mapaLugar.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaLugar.Name = "mapaLugar";
            this.mapaLugar.NegativeMode = false;
            this.mapaLugar.PolygonsEnabled = true;
            this.mapaLugar.RetryLoadTile = 0;
            this.mapaLugar.RoutesEnabled = true;
            this.mapaLugar.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaLugar.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaLugar.ShowTileGridLines = false;
            this.mapaLugar.Size = new System.Drawing.Size(306, 231);
            this.mapaLugar.TabIndex = 1;
            this.mapaLugar.Zoom = 0D;
            // 
            // VentanaMuestraLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.ratLugar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.dgVisitas);
            this.Controls.Add(this.sepH1);
            this.Controls.Add(this.sepH2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.staticDesc);
            this.Controls.Add(this.staticCiudad);
            this.Controls.Add(this.staticEtiq);
            this.Controls.Add(this.staticCat);
            this.Controls.Add(this.staticLong);
            this.Controls.Add(this.staticLat);
            this.Controls.Add(this.mapaLugar);
            this.Controls.Add(this.lblNombreLugar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaMuestraLugar";
            this.Text = "VentanaMuestraLugar";
            this.Load += new System.EventHandler(this.VentanaMuestraLugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreLugar;
        private System.Windows.Forms.Label staticLat;
        private System.Windows.Forms.Label staticLong;
        private System.Windows.Forms.Label staticCat;
        private System.Windows.Forms.Label staticEtiq;
        private System.Windows.Forms.Label staticCiudad;
        private System.Windows.Forms.Label staticDesc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Bunifu.Framework.UI.BunifuSeparator sepH2;
        private Bunifu.Framework.UI.BunifuSeparator sepH1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgVisitas;
        private Bunifu.Framework.UI.BunifuRating ratLugar;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label lblCategoria;
        private GMap.NET.WindowsForms.GMapControl mapaLugar;
    }
}