﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_Peliculas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void nuevaPelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPelicula fp = new frmPelicula();
            fp.ShowDialog();
        }
    }
}
