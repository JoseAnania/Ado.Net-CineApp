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
    public partial class frmAmbPelicula : Form
    {
        const int tam = 100;
        Peliculas[] p = new Peliculas[tam];
        Persona[] a = new Persona[tam];
        decimal[] actor = new decimal[5] { 0, 0, 0, 0, 0 };
        Peliculas peli;
        Director[] d = new Director[tam];
        int c = 0;
        int j = 0;
        DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
        DataTable tabla = new DataTable();
        
        public frmAmbPelicula()
        {
            InitializeComponent();
        }
        public void cargarListaActores()
        {
            c = 0;
            lstActores.Items.Clear();
            dato.leerTabla("actores");
            
            while (dato.Dr.Read())
            {
                a[c] = new Persona();
                if(!dato.Dr.IsDBNull(0))
                    a[c].Codigo = Convert.ToInt32(dato.Dr.GetDecimal(0));
                if (!dato.Dr.IsDBNull(1))
                    a[c].Apellido = dato.Dr.GetString(1);
                if (!dato.Dr.IsDBNull(2))
                    a[c].Nombre = dato.Dr.GetString(2);
                c++;
            }
            dato.desconectar();
            for (int i = 0; i < c; i++)
            {
                lstActores.Items.Add(a[i].ToString());
            }
        }
        public void cargarListaPeliculas()
        {
            c = 0;
            lstPeliculas.Items.Clear();
            dato.leerTabla("peliculas");
            while (dato.Dr.Read())
            {
                p[c] = new Peliculas();
                if (!dato.Dr.IsDBNull(0))
                    p[c].Codigo = Convert.ToInt32(dato.Dr.GetDecimal(0));
                if (!dato.Dr.IsDBNull(1))
                    p[c].Nombre = dato.Dr.GetString(1);
                if (!dato.Dr.IsDBNull(2))
                    p[c].FechaEstreno = dato.Dr.GetDateTime(2);
                if (!dato.Dr.IsDBNull(3))
                    p[c].Genero = Convert.ToInt32(dato.Dr.GetDecimal(3));
                if (!dato.Dr.IsDBNull(4))
                    p[c].Clasificacion = Convert.ToInt32(dato.Dr.GetDecimal(4));
                if (!dato.Dr.IsDBNull(5))
                    p[c].Director = Convert.ToInt32(dato.Dr.GetDecimal(5));
                c++;
            }
            dato.desconectar();
            for (int i=0; i<c;i++)
            {
                dato.leer("select cod_actor from actores_peliculas where cod_pelicula = "+p[i].Codigo);
                int cont = 0;
                while (dato.Dr.Read())
                {
                    p[i].Actores[cont] = Convert.ToInt32(dato.Dr.GetDecimal(0));
                    cont++;
                }
                dato.desconectar();
                lstPeliculas.Items.Add(p[i].ToString());
            }    
        }
        private void activarbotonesAltas (bool x)
        {
            btnNuevo.Enabled = x;
            btnNuevo.Visible = x;
            btnCancelar1.Enabled = x;
            btnCancelar1.Visible = x;
            btnNuevaP.Enabled = !x;
            btnNuevaP.Visible = !x;
            activarCagas(x);
        }
        private void activarbotonesModificar (bool x)
        {
            btnGuardar.Enabled = x;
            btnGuardar.Visible = x;
            btnCancelar2.Enabled = x;
            btnCancelar2.Visible = x;
            btnModificar.Enabled = !x;
            btnModificar.Visible = !x;
            activarCagas(x);
        }
        private void activarCagas(bool x)
        {
            txNombre.Enabled = x;
            cmbClasificacion.Enabled = x;
            cmbDirector.Enabled = x;
            cmbGenero.Enabled = x;
            dtpFecha_est.Enabled = x;
            btnAgregar.Enabled = x;
            btnRefresh.Enabled = x;
            lstPeliculas.Enabled = !x;
        }
       
        private void frmAmbPelicula_Load(object sender, EventArgs e)
        {
            activarbotonesAltas(false);
            btnModificar.Enabled = false;
            
            cargarCombo(cmbClasificacion, "clasificaciones");
            cargarCombo(cmbGenero, "generos");
            tabla = dato.consultar("select cod_director, nom_director +' '+ape_director as 'Director' from directores");
            cargarListaActores();
            cargarListaPeliculas();
            cmbDirector.DataSource = tabla;
            cmbDirector.ValueMember = tabla.Columns[0].ColumnName;
            cmbDirector.DisplayMember = tabla.Columns[1].ColumnName;
            cmbDirector.SelectedIndex = 0;
            dato.leerTabla("directores");
            int i = 0;
            while(dato.Dr.Read())
            {
                d[i] = new Director();
                if (!dato.Dr.IsDBNull(0))
                    d[i].Codigo = Convert.ToInt32(dato.Dr.GetDecimal(0));                  
                if (!dato.Dr.IsDBNull(1))
                    d[i].Apellido = dato.Dr.GetString(1);
                if (!dato.Dr.IsDBNull(2))
                    d[i].Nombre = dato.Dr.GetString(2);
                i++;
            }
            dato.desconectar();
            

        }
        private void cargarCombo(ComboBox combo,string nom_tabla)
        {
            this.tabla = dato.consultarTabla(nom_tabla);
            combo.DataSource = this.tabla;
            combo.ValueMember = this.tabla.Columns[0].ColumnName;
            combo.DisplayMember = this.tabla.Columns[1].ColumnName;
            combo.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if(j==5)
            {
                MessageBox.Show("Maximo 5 actores por pelicula");
            }
            else
            { 
            if (chequearActor())
            {
                lstActoresP.Items.Add(lstActores.SelectedItem);
                actor[j] = a[lstActores.SelectedIndex].Codigo;
                j++;
            }
            else
                MessageBox.Show("Actor ya agregado");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstActoresP.Items.Clear();
            actor = new decimal[5] {0,0,0,0,0};
            j = 0;
        }
        public bool chequearActor()
        {
            bool a=true;
            for(int i =0; i<j;i++)
            {
                if (actor[i] == this.a[lstActores.SelectedIndex].Codigo)
                    a = false;
            }
            return a;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txNombre.Text == "")
                MessageBox.Show("ingrese un mobre");
            else
            { 
                string fecha;
                int cod_peli;
                peli = new Tp_final_cine.Peliculas();
                peli.Clasificacion = cmbClasificacion.SelectedIndex + 1;
                peli.Director = d[cmbDirector.SelectedIndex + 1].Codigo;
                peli.FechaEstreno = dtpFecha_est.Value;
                fecha = peli.FechaEstreno.Year + "/" + peli.FechaEstreno.Month + "/" + peli.FechaEstreno.Day;
                peli.Genero = cmbGenero.SelectedIndex + 1;
                peli.Actores[0] = actor[0];
                peli.Actores[1] = actor[1];
                peli.Actores[2] = actor[2];
                peli.Actores[3] = actor[3];
                peli.Actores[4] = actor[4];
                peli.Nombre = txNombre.Text;

                dato.actualizar("exec agregar_pelicula '"+peli.Nombre+"' , '"+fecha+"' , "+peli.Genero + " , "+peli.Clasificacion+" , "+peli.Director);
           
                cod_peli = dato.consultarDato("select max(cod_pelicula) from peliculas");
            
           
                for (int i =0; i<5;i++)
                {
                    if (peli.Actores[i] != 0)
                        dato.actualizar("exec agregar_actor_pelicula "+ cod_peli + " , " + peli.Actores[i]); 
                }

                MessageBox.Show("Pelicula agregada");
                cargarListaPeliculas();
                activarbotonesAltas(false);
            }

        }

        private void btnNuevaP_Click(object sender, EventArgs e)
        {
            activarbotonesAltas(true);
            btnModificar.Enabled = false;
            
            btnSalir.Enabled = false;
            txNombre.Text = "";
            txNombre.Focus();
            dtpFecha_est.Value = DateTime.Today;
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            activarbotonesAltas(false);
            
            btnSalir.Enabled = true;
        }

        private void lstPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            
            lstActoresP.Items.Clear();
            txNombre.Text = p[lstPeliculas.SelectedIndex].Nombre;
            dtpFecha_est.Value = p[lstPeliculas.SelectedIndex].FechaEstreno;
            cmbGenero.SelectedIndex = p[lstPeliculas.SelectedIndex].Genero-1;
            cmbDirector.SelectedIndex = p[lstPeliculas.SelectedIndex].Director-1;
            cmbClasificacion.SelectedIndex = p[lstPeliculas.SelectedIndex].Clasificacion-1;
            for (int i=0; i<5;i++)
            {
                if ((Convert.ToInt32(p[lstPeliculas.SelectedIndex].Actores[i]) - 1) > -1)
                lstActoresP.Items.Add( a[Convert.ToInt32(p[lstPeliculas.SelectedIndex].Actores[i])-1].Nombre +" " + a[Convert.ToInt32(p[lstPeliculas.SelectedIndex].Actores[i])-1].Apellido);


            }

        }

        private void lstPeliculas_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lstPeliculas_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarbotonesModificar(true);
            btnNuevaP.Enabled=false;
            
            btnSalir.Enabled = false;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            activarbotonesModificar(false);
            btnNuevaP.Enabled = true;
            
            btnSalir.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txNombre.Text == "")
                MessageBox.Show("ingrese un mobre");
            else
            {

                string fecha;
            
                peli = new Tp_final_cine.Peliculas();
                peli.Clasificacion = cmbClasificacion.SelectedIndex + 1;
                peli.Director = d[cmbDirector.SelectedIndex + 1].Codigo;
                peli.FechaEstreno = dtpFecha_est.Value;
                fecha = peli.FechaEstreno.Year + "/" + peli.FechaEstreno.Month + "/" + peli.FechaEstreno.Day;
                peli.Genero = cmbGenero.SelectedIndex + 1;
                peli.Actores[0] = actor[0];
                peli.Actores[1] = actor[1];
                peli.Actores[2] = actor[2];
                peli.Actores[3] = actor[3];
                peli.Actores[4] = actor[4];
                peli.Nombre = txNombre.Text;
                peli.Codigo = p[lstPeliculas.SelectedIndex].Codigo;
                dato.actualizar("update peliculas set nom_pelicula = '" + peli.Nombre+"' , fec_estreno = '"+fecha+"' , cod_genero = "+peli.Genero+" , cod_clasificacion = "+peli.Clasificacion+" , cod_director = "+peli.Director+" where cod_pelicula = "+peli.Codigo);
                dato.actualizar ("delete actores_peliculas where cod_pelicula = "+peli.Codigo);
                for (int i = 0; i < 5; i++)
                {
                    if (peli.Actores[i] != 0)
                        dato.actualizar("exec agregar_actor_pelicula " + peli.Codigo + " , " + peli.Actores[i]);
                }
                MessageBox.Show("Pelicula actualizada");
                cargarListaPeliculas();
                activarbotonesModificar(false);
                btnNuevaP.Enabled = true;
                btnSalir.Enabled = true;
                btnModificar.Enabled = false;
            }
        }
    }
}
