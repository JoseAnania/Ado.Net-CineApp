using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_final_cine
{
    class Persona
    {
        string nombre, apellido;
        int codigo;

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public Persona ()
        {
            nombre = apellido = "";
            codigo = 0;
        }
        public Persona (string nombre,string apellido,int codigo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
        }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
