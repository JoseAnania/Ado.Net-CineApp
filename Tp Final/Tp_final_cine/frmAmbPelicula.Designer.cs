namespace Tp_final_cine
{
    partial class frmAmbPelicula
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.dtpFecha_est = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.lstActores = new System.Windows.Forms.ListBox();
            this.lstActoresP = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevaP = new System.Windows.Forms.Button();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(123, 24);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(200, 20);
            this.txNombre.TabIndex = 1;
            // 
            // dtpFecha_est
            // 
            this.dtpFecha_est.Location = new System.Drawing.Point(123, 50);
            this.dtpFecha_est.Name = "dtpFecha_est";
            this.dtpFecha_est.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_est.TabIndex = 2;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(29, 56);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEstreno.TabIndex = 3;
            this.lblFechaEstreno.Text = "Fecha de estreno";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(123, 78);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(149, 21);
            this.cmbGenero.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(75, 81);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(51, 111);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(66, 13);
            this.lblClasificacion.TabIndex = 7;
            this.lblClasificacion.Text = "Clasificacion";
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(123, 108);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(149, 21);
            this.cmbClasificacion.TabIndex = 6;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(73, 142);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director";
            // 
            // cmbDirector
            // 
            this.cmbDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(123, 139);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(149, 21);
            this.cmbDirector.TabIndex = 8;
            // 
            // lstActores
            // 
            this.lstActores.FormattingEnabled = true;
            this.lstActores.Location = new System.Drawing.Point(365, 24);
            this.lstActores.Name = "lstActores";
            this.lstActores.Size = new System.Drawing.Size(120, 134);
            this.lstActores.TabIndex = 10;
            // 
            // lstActoresP
            // 
            this.lstActoresP.FormattingEnabled = true;
            this.lstActoresP.Location = new System.Drawing.Point(521, 24);
            this.lstActoresP.Name = "lstActoresP";
            this.lstActoresP.Size = new System.Drawing.Size(120, 134);
            this.lstActoresP.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(491, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(479, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(159, 192);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.Location = new System.Drawing.Point(365, 192);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(276, 212);
            this.lstPeliculas.TabIndex = 16;
            this.lstPeliculas.SelectedIndexChanged += new System.EventHandler(this.lstPeliculas_SelectedIndexChanged);
            this.lstPeliculas.MouseEnter += new System.EventHandler(this.lstPeliculas_MouseEnter);
            this.lstPeliculas.MouseLeave += new System.EventHandler(this.lstPeliculas_MouseLeave);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Enabled = false;
            this.btnCancelar1.Location = new System.Drawing.Point(240, 192);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar1.TabIndex = 25;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Visible = false;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(159, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(78, 269);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(78, 230);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevaP
            // 
            this.btnNuevaP.Location = new System.Drawing.Point(76, 192);
            this.btnNuevaP.Name = "btnNuevaP";
            this.btnNuevaP.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaP.TabIndex = 26;
            this.btnNuevaP.Text = "Nueva";
            this.btnNuevaP.UseVisualStyleBackColor = true;
            this.btnNuevaP.Click += new System.EventHandler(this.btnNuevaP_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Enabled = false;
            this.btnCancelar2.Location = new System.Drawing.Point(240, 230);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar2.TabIndex = 27;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Visible = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // frmAmbPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 434);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnNuevaP);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lstPeliculas);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstActoresP);
            this.Controls.Add(this.lstActores);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.cmbDirector);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.dtpFecha_est);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAmbPelicula";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.frmAmbPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha_est;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.ListBox lstActores;
        private System.Windows.Forms.ListBox lstActoresP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevaP;
        private System.Windows.Forms.Button btnCancelar2;
    }
}