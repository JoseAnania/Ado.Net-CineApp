using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_final_cine
{
    class Peliculas
    {
        int codigo, genero, clasificacion, director;
        decimal[] actores = new decimal[5];
        DateTime fechaEstreno;
        string nombre;

        public int Clasificacion
        {
            get
            {
                return clasificacion;
            }

            set
            {
                clasificacion = value;
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

        public int Director
        {
            get
            {
                return director;
            }

            set
            {
                director = value;
            }
        }

        public DateTime FechaEstreno
        {
            get
            {
                return fechaEstreno;
            }

            set
            {
                fechaEstreno = value;
            }
        }

        public int Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
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

        public decimal[] Actores
        {
            get
            {
                return actores;
            }

            set
            {
                actores = value;
            }
        }

        public Peliculas ()
        {
            codigo = director = clasificacion = genero = 0;
            fechaEstreno = DateTime.Today;
            nombre = "";
        }
        public Peliculas (int codigo,int director,int clasificacion,int genero, DateTime fechaEstreno, string nombre)
        {
            this.codigo = codigo;
            this.director = director;
            this.clasificacion = clasificacion;
            this.genero = genero;
            this.fechaEstreno = fechaEstreno;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
