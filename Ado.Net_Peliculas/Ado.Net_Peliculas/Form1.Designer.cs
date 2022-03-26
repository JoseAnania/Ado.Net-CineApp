namespace Ado.Net_Peliculas
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPelículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPelículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúDirectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúActoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoActorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarActorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.películasToolStripMenuItem,
            this.directoresToolStripMenuItem,
            this.actoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPelículasToolStripMenuItem});
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.películasToolStripMenuItem.Text = "Películas";
            // 
            // menúPelículasToolStripMenuItem
            // 
            this.menúPelículasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPelículaToolStripMenuItem,
            this.modificarPelículaToolStripMenuItem});
            this.menúPelículasToolStripMenuItem.Name = "menúPelículasToolStripMenuItem";
            this.menúPelículasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.menúPelículasToolStripMenuItem.Text = "Menú Películas";
            // 
            // nuevaPelículaToolStripMenuItem
            // 
            this.nuevaPelículaToolStripMenuItem.Name = "nuevaPelículaToolStripMenuItem";
            this.nuevaPelículaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevaPelículaToolStripMenuItem.Text = "Nueva Película";
            this.nuevaPelículaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPelículaToolStripMenuItem_Click);
            // 
            // modificarPelículaToolStripMenuItem
            // 
            this.modificarPelículaToolStripMenuItem.Name = "modificarPelículaToolStripMenuItem";
            this.modificarPelículaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificarPelículaToolStripMenuItem.Text = "Modificar Película";
            // 
            // directoresToolStripMenuItem
            // 
            this.directoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúDirectoresToolStripMenuItem});
            this.directoresToolStripMenuItem.Name = "directoresToolStripMenuItem";
            this.directoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.directoresToolStripMenuItem.Text = "Directores";
            // 
            // menúDirectoresToolStripMenuItem
            // 
            this.menúDirectoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDirectorToolStripMenuItem,
            this.modificarDirectorToolStripMenuItem});
            this.menúDirectoresToolStripMenuItem.Name = "menúDirectoresToolStripMenuItem";
            this.menúDirectoresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.menúDirectoresToolStripMenuItem.Text = "Menú Directores";
            // 
            // nuevoDirectorToolStripMenuItem
            // 
            this.nuevoDirectorToolStripMenuItem.Name = "nuevoDirectorToolStripMenuItem";
            this.nuevoDirectorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoDirectorToolStripMenuItem.Text = "Nuevo Director";
            // 
            // modificarDirectorToolStripMenuItem
            // 
            this.modificarDirectorToolStripMenuItem.Name = "modificarDirectorToolStripMenuItem";
            this.modificarDirectorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarDirectorToolStripMenuItem.Text = "Modificar Director";
            // 
            // actoresToolStripMenuItem
            // 
            this.actoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúActoresToolStripMenuItem});
            this.actoresToolStripMenuItem.Name = "actoresToolStripMenuItem";
            this.actoresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actoresToolStripMenuItem.Text = "Actores";
            // 
            // menúActoresToolStripMenuItem
            // 
            this.menúActoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoActorToolStripMenuItem,
            this.modificarActorToolStripMenuItem});
            this.menúActoresToolStripMenuItem.Name = "menúActoresToolStripMenuItem";
            this.menúActoresToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.menúActoresToolStripMenuItem.Text = "Menú Actores";
            // 
            // nuevoActorToolStripMenuItem
            // 
            this.nuevoActorToolStripMenuItem.Name = "nuevoActorToolStripMenuItem";
            this.nuevoActorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoActorToolStripMenuItem.Text = "Nuevo Actor";
            // 
            // modificarActorToolStripMenuItem
            // 
            this.modificarActorToolStripMenuItem.Name = "modificarActorToolStripMenuItem";
            this.modificarActorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificarActorToolStripMenuItem.Text = "Modificar Actor";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 371);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúDirectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúActoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPelículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPelículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoActorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarActorToolStripMenuItem;
    }
}

