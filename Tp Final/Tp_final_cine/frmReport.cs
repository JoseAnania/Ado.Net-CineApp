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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.actores' table. You can move, or remove it, as needed.
            // this.actoresTableAdapter.Fill(this.DataSet1.actores);

           // this.reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DataAccess ad = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
            string sql = "Select * from actores where nom_actor like '%" + txtReportNom.Text+"%' and ape_actor like '%"+txtReportApe.Text +"%'";
            this.actoresBindingSource.DataSource = ad.consultar(sql);
            this.reportViewer1.RefreshReport();
        }
    }
}
