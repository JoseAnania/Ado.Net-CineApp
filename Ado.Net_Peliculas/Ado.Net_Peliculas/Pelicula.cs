using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_Peliculas
{
    class Pelicula
    {
        private int cod_pelicula;
        private string nom_pelicula;
        private int genero;
        private string clasificacion;
        private int cod_director;
        private DateTime fec_estreno;

        public int pCod_pelicula
        {
            get
            {
                return cod_pelicula;
            }

            set
            {
                cod_pelicula = value;
            }
        }

        public string pNom_pelicula
        {
            get
            {
                return nom_pelicula;
            }

            set
            {
                nom_pelicula = value;
            }
        }

        public int pGenero
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

        public string pClasificacion
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

        public int pCod_director
        {
            get
            {
                return cod_director;
            }

            set
            {
                cod_director = value;
            }
        }

        public DateTime pFec_estreno
        {
            get
            {
                return fec_estreno;
            }

            set
            {
                fec_estreno = value;
            }
        }
        public string toString()
        {
            return cod_pelicula + " - " + nom_pelicula;
        }
    }
}
