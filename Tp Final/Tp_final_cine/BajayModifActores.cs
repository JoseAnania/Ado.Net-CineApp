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
    public partial class BajayModifActores : Form
    {
        const int tam = 500;
        Persona[] vp = new Persona[tam];
        DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
        public BajayModifActores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            if (MessageBox.Show("¿Desea Salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void BajayModifActores_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            cargarLista();
            

        }

        private void lstActores_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApellido.Text = vp[lstActores.SelectedIndex].Apellido;
            txtNombre.Text = vp[lstActores.SelectedIndex].Nombre;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            
        }
        public void cargarLista()
        {
            lstActores.Items.Clear();
            dato.leerTabla("actores");
            int c = 0;
            while (dato.Dr.Read())
            {
                vp[c] = new Persona();
                vp[c].Codigo = Convert.ToInt32(dato.Dr.GetDecimal(0));
                vp[c].Apellido = dato.Dr.GetString(1);
                vp[c].Nombre = dato.Dr.GetString(2);
                c++;
            }
            dato.desconectar();
            for (int i = 0; i < c; i++)
            {
                lstActores.Items.Add(vp[i].ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarbotones(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activarbotones(false);
        }

        private void activarbotones(bool x)
        {
            lstActores.Enabled = !x;
            btnAgregar.Enabled = !x;
            btnGuardar.Enabled = x;
            btnGuardar.Visible = x;
            btnCancelar.Visible = x;
            btnCancelar.Enabled = x;
            btnModificar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                MessageBox.Show("Apellido Incompleto");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre Incompleto");
            else
            {
                vp[lstActores.SelectedIndex].Apellido = txtApellido.Text;
                vp[lstActores.SelectedIndex].Nombre = txtNombre.Text;
                dato.actualizar("update actores set nom_actor = '"+vp[lstActores.SelectedIndex].Nombre+"', ape_actor= '"+ vp[lstActores.SelectedIndex].Apellido+"' where cod_actor = "+ vp[lstActores.SelectedIndex].Codigo);
                MessageBox.Show("Actor actualizado");
                cargarLista();
                activarbotones(false);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            int ca;
            ca = dato.consultarDato("select count(*) from actores_peliculas where cod_actor = " + vp[lstActores.SelectedIndex].Codigo);
            if (ca == 0)
            {
                if (MessageBox.Show("¿Desea Eliminar este actor?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dato.actualizar("delete actores where cod_actor = " + vp[lstActores.SelectedIndex].Codigo);
                    cargarLista();
                    MessageBox.Show("Actor eliminado");
                    txtApellido.Clear();
                    txtNombre.Clear();
                    btnBorrar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
            else
                MessageBox.Show("No se puede eliminar este actor ya que esta asignado a "+ ca +" pelicula/s");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                MessageBox.Show("Apellido Incompleto");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre Incompleto");
            else
            {
                Persona a = new Persona(txtNombre.Text, txtApellido.Text, 0);
                DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
                dato.actualizar("insert into actores (ape_actor,nom_actor) values ('" + a.Apellido + "','" + a.Nombre + "')");
                MessageBox.Show("Actor Cargado correctamente");
                cargarLista();
                txtApellido.Clear();
                txtNombre.Clear();
                txtNombre.Focus();


            }
        }
    }
}
