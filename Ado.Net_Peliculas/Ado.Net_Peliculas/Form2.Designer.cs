namespace Ado.Net_Peliculas
{
    partial class frmPelicula
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
            this.lblCodigoPelicula = new System.Windows.Forms.Label();
            this.txtCodigoPelicula = new System.Windows.Forms.TextBox();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblClasificación = new System.Windows.Forms.Label();
            this.rbtATP = new System.Windows.Forms.RadioButton();
            this.rbt13 = new System.Windows.Forms.RadioButton();
            this.rbt16 = new System.Windows.Forms.RadioButton();
            this.rbt18 = new System.Windows.Forms.RadioButton();
            this.txtCodigoDirector = new System.Windows.Forms.TextBox();
            this.lblCodigoDirector = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstPelicula = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCodigoPelicula
            // 
            this.lblCodigoPelicula.AutoSize = true;
            this.lblCodigoPelicula.Location = new System.Drawing.Point(13, 34);
            this.lblCodigoPelicula.Name = "lblCodigoPelicula";
            this.lblCodigoPelicula.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoPelicula.TabIndex = 0;
            this.lblCodigoPelicula.Text = "Código Película";
            // 
            // txtCodigoPelicula
            // 
            this.txtCodigoPelicula.Location = new System.Drawing.Point(101, 31);
            this.txtCodigoPelicula.Name = "txtCodigoPelicula";
            this.txtCodigoPelicula.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoPelicula.TabIndex = 0;
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(101, 73);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(168, 20);
            this.txtNombrePelicula.TabIndex = 1;
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Location = new System.Drawing.Point(13, 76);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(86, 13);
            this.lblNombrePelicula.TabIndex = 2;
            this.lblNombrePelicula.Text = "Nombre Película";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(31, 117);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(101, 114);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(168, 21);
            this.cboGenero.TabIndex = 2;
            // 
            // lblClasificación
            // 
            this.lblClasificación.AutoSize = true;
            this.lblClasificación.Location = new System.Drawing.Point(17, 163);
            this.lblClasificación.Name = "lblClasificación";
            this.lblClasificación.Size = new System.Drawing.Size(66, 13);
            this.lblClasificación.TabIndex = 3;
            this.lblClasificación.Text = "Clasificación";
            // 
            // rbtATP
            // 
            this.rbtATP.AutoSize = true;
            this.rbtATP.Location = new System.Drawing.Point(34, 192);
            this.rbtATP.Name = "rbtATP";
            this.rbtATP.Size = new System.Drawing.Size(46, 17);
            this.rbtATP.TabIndex = 7;
            this.rbtATP.TabStop = true;
            this.rbtATP.Text = "ATP";
            this.rbtATP.UseVisualStyleBackColor = true;
            // 
            // rbt13
            // 
            this.rbt13.AutoSize = true;
            this.rbt13.Location = new System.Drawing.Point(34, 215);
            this.rbt13.Name = "rbt13";
            this.rbt13.Size = new System.Drawing.Size(43, 17);
            this.rbt13.TabIndex = 8;
            this.rbt13.TabStop = true;
            this.rbt13.Text = "+13";
            this.rbt13.UseVisualStyleBackColor = true;
            // 
            // rbt16
            // 
            this.rbt16.AutoSize = true;
            this.rbt16.Location = new System.Drawing.Point(34, 238);
            this.rbt16.Name = "rbt16";
            this.rbt16.Size = new System.Drawing.Size(43, 17);
            this.rbt16.TabIndex = 9;
            this.rbt16.TabStop = true;
            this.rbt16.Text = "+16";
            this.rbt16.UseVisualStyleBackColor = true;
            // 
            // rbt18
            // 
            this.rbt18.AutoSize = true;
            this.rbt18.Location = new System.Drawing.Point(34, 261);
            this.rbt18.Name = "rbt18";
            this.rbt18.Size = new System.Drawing.Size(43, 17);
            this.rbt18.TabIndex = 10;
            this.rbt18.TabStop = true;
            this.rbt18.Text = "+18";
            this.rbt18.UseVisualStyleBackColor = true;
            // 
            // txtCodigoDirector
            // 
            this.txtCodigoDirector.Location = new System.Drawing.Point(105, 299);
            this.txtCodigoDirector.Name = "txtCodigoDirector";
            this.txtCodigoDirector.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoDirector.TabIndex = 4;
            // 
            // lblCodigoDirector
            // 
            this.lblCodigoDirector.AutoSize = true;
            this.lblCodigoDirector.Location = new System.Drawing.Point(17, 302);
            this.lblCodigoDirector.Name = "lblCodigoDirector";
            this.lblCodigoDirector.Size = new System.Drawing.Size(80, 13);
            this.lblCodigoDirector.TabIndex = 11;
            this.lblCodigoDirector.Text = "Código Director";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(17, 344);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(91, 13);
            this.lblFechaEstreno.TabIndex = 13;
            this.lblFechaEstreno.Text = "Fecha de Estreno";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(353, 142);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(353, 186);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // lstPelicula
            // 
            this.lstPelicula.FormattingEnabled = true;
            this.lstPelicula.Location = new System.Drawing.Point(468, 13);
            this.lstPelicula.Name = "lstPelicula";
            this.lstPelicula.Size = new System.Drawing.Size(214, 342);
            this.lstPelicula.TabIndex = 17;
            // 
            // frmPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(751, 375);
            this.Controls.Add(this.lstPelicula);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.txtCodigoDirector);
            this.Controls.Add(this.lblCodigoDirector);
            this.Controls.Add(this.rbt18);
            this.Controls.Add(this.rbt16);
            this.Controls.Add(this.rbt13);
            this.Controls.Add(this.rbtATP);
            this.Controls.Add(this.lblClasificación);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNombrePelicula);
            this.Controls.Add(this.lblNombrePelicula);
            this.Controls.Add(this.txtCodigoPelicula);
            this.Controls.Add(this.lblCodigoPelicula);
            this.Name = "frmPelicula";
            this.Text = "Películas";
            this.Load += new System.EventHandler(this.frmPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoPelicula;
        private System.Windows.Forms.TextBox txtCodigoPelicula;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.Label lblNombrePelicula;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblClasificación;
        private System.Windows.Forms.RadioButton rbtATP;
        private System.Windows.Forms.RadioButton rbt13;
        private System.Windows.Forms.RadioButton rbt16;
        private System.Windows.Forms.RadioButton rbt18;
        private System.Windows.Forms.TextBox txtCodigoDirector;
        private System.Windows.Forms.Label lblCodigoDirector;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstPelicula;
    }
}