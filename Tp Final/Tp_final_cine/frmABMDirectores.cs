using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tp_final_cine
{
    public partial class frmABMDirectores : Form
    {
        const int tam = 500;
        Director[] vp = new Director[tam];
        DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
        public frmABMDirectores()
        {
            InitializeComponent();
        }

        private void frmABMDirectores_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            cargarLista();
            cmbNacion.SelectedIndex = 0;

        }
        private void activarbotones(bool x)
        {
            lstDirectores.Enabled = !x;
            btnAgregar.Enabled = !x;
            btnGuardar.Enabled = x;
            btnGuardar.Visible = x;
            btnCancelar.Visible = x;
            btnCancelar.Enabled = x;
            btnModificar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
        }
        public void cargarLista()
        {
            lstDirectores.Items.Clear();
            dato.leerTabla("directores");
            int c = 0;
            while (dato.Dr.Read())
            {
                vp[c] = new Director();
                vp[c].Codigo = Convert.ToInt32(dato.Dr.GetDecimal(0));
                vp[c].Apellido = dato.Dr.GetString(1);
                vp[c].Nombre = dato.Dr.GetString(2);
                vp[c].Nacionalidad = dato.Dr.GetString(3);
                c++;
            }
            dato.desconectar();
            for (int i = 0; i < c; i++)
            {
                lstDirectores.Items.Add(vp[i].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                MessageBox.Show("Apellido Incompleto");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre Incompleto");
            else
            {
                Director a = new Director(txtNombre.Text, txtApellido.Text,cmbNacion.Text ,0);
                DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
                dato.actualizar("insert into directores (ape_director,nom_director,nacionalidad) values ('" + a.Apellido + "','" + a.Nombre + "','" +a.Nacionalidad +"')");
                MessageBox.Show("Actor Cargado correctamente");
                cargarLista();
                txtApellido.Clear();
                txtNombre.Clear();
                txtNombre.Focus();


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            if (MessageBox.Show("¿Desea Salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void lstDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApellido.Text = vp[lstDirectores.SelectedIndex].Apellido;
            txtNombre.Text = vp[lstDirectores.SelectedIndex].Nombre;
            cmbNacion.Text = vp[lstDirectores.SelectedIndex].Nacionalidad;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarbotones(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activarbotones(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                MessageBox.Show("Apellido Incompleto");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre Incompleto");
            else
            {
                vp[lstDirectores.SelectedIndex].Apellido = txtApellido.Text;
                vp[lstDirectores.SelectedIndex].Nombre = txtNombre.Text;
                vp[lstDirectores.SelectedIndex].Nacionalidad = cmbNacion.Text;
                dato.actualizar("update directores set nom_director = '" + vp[lstDirectores.SelectedIndex].Nombre + "', ape_director= '" + vp[lstDirectores.SelectedIndex].Apellido +"', nacionalidad= '"+vp[lstDirectores.SelectedIndex].Nacionalidad+ "' where cod_director = " + vp[lstDirectores.SelectedIndex].Codigo);
                MessageBox.Show("Director actualizado");
                cargarLista();
                activarbotones(false);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            int cd;
            cd = dato.consultarDato("select count(*) from peliculas where cod_director = "+vp[lstDirectores.SelectedIndex].Codigo);
            if (cd == 0)
            {
                if (MessageBox.Show("¿Desea Eliminar este actor?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dato.actualizar("delete directores where cod_director = " + vp[lstDirectores.SelectedIndex].Codigo);
                    cargarLista();
                    MessageBox.Show("Director eliminado");
                    txtApellido.Clear();
                    txtNombre.Clear();
                    btnBorrar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
            else
                MessageBox.Show("no se puede borrar este director ya que esta asignado a "+ cd +" pelicula/s");
        }
    }
}
