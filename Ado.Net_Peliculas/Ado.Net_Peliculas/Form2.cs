using System;
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
    public partial class frmPelicula : Form
    {

        accesoDatos datos = new accesoDatos(@"Provider=SQLNCLI11;Data Source=DESKTOP-E8FRIUV\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=peliculas");
        const int tam = 100;
        Pelicula[] vp = new Pelicula[tam];
        int c = 0;
        public frmPelicula()
        {
            InitializeComponent();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            cargarCombo(cboGenero, "generos");
            cargarLista("peliculas");
        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = datos.consultarTabla(nombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }
        public void cargarLista(string nombreTabla)
        {
            c = 0;
            datos.leerTabla(nombreTabla);
            while (datos.pDr.Read())
            {
                Pelicula p = new Pelicula();
                if (datos.pDr.IsDBNull(0))
                    p.pCod_pelicula = datos.pDr.GetInt32(0);
                if (!datos.pDr.IsDBNull(1))
                    p.pNom_pelicula = datos.pDr.GetString(1);
                if (datos.pDr.IsDBNull(2))
                    p.pGenero = datos.pDr.GetInt32(2);
                if (!datos.pDr.IsDBNull(3))
                    p.pClasificacion = datos.pDr.GetString(3);
                if (datos.pDr.IsDBNull(4))
                    p.pCod_director = datos.pDr.GetInt32(4);
                if (!datos.pDr.IsDBNull(5))
                    p.pFec_estreno = datos.pDr.GetDateTime(5);

                vp[c] = p;
                c++;
            }
            datos.pDr.Close();
            datos.desconectar();

            lstPelicula.Items.Clear();

            for (int i = 0; i < c; i++)
                lstPelicula.Items.Add(vp[i].toString());
        }
    }
}
