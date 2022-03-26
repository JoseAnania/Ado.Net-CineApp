using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_final_cine
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaActores alta = new Tp_final_cine.AltaActores();
            alta.Show();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajayModifActores bm = new BajayModifActores();
            bm.Show();
        }

        private void agregarModificarYEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMDirectores abmd = new Tp_final_cine.frmABMDirectores();
            abmd.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAmbPelicula frm = new frmAmbPelicula();
            frm.Show();
        }

        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas form = new frmConsultas();
            form.Show();
        }

        private void agregarModificarYEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAmbPelicula form = new Tp_final_cine.frmAmbPelicula();
            form.Show();
        }

        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport form = new Tp_final_cine.frmReport();
            form.Show();
        }
    }
}
