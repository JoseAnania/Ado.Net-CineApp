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
    public partial class AltaActores : Form
    {
        public AltaActores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
            if (MessageBox.Show("¿Desea Salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                MessageBox.Show("Apellido Incompleto");
            else if (txtNombre.Text == "")
                MessageBox.Show("Nombre Incompleto");
            else
            {
                Persona a = new Persona(txtNombre.Text, txtApellido.Text,0);
                DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
                dato.actualizar("insert into actores (ape_actor,nom_actor) values ('" + a.Apellido + "','" + a.Nombre + "')");
                MessageBox.Show("Actor Cargado correctamente");
                txtApellido.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                

            }
        }
    }
}
