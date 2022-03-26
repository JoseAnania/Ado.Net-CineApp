using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_final_cine
{
    class Director :Persona
    {
        string nacionalidad;

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }
        public Director() : base()
        { 
            nacionalidad = "";
        }
        public Director(string nombre, string apellido,string nacionalidad,int codigo) : base (nombre,apellido,codigo)
        {
            this.nacionalidad = nacionalidad;
        }
        public override string ToString()
        {
            return base.ToString()+" Nacionalidad: "+nacionalidad;
        }
    }
}
