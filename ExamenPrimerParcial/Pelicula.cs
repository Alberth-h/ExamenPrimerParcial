using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Pelicula
    {
        //Auto Properties
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Origen { get; set; }
        public string Sipnosis { get; set; }

        //Properties
        private int _estreno;
        public int Estreno
        {
            get
            {
                return _estreno;
            }

            set
            {
                if((value > 1799) && (value < 2020))
                {
                    _estreno = value;
                }
                else
                {
                    throw new Exception("Año fuera de rango");
                }
            }
        }
        private int _duracion { get; set; }
        public int Duracion
        {
            get
            {
                return _duracion;
            }

            set
            {
                if((value > -1))
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("Duracion invalida");
                }
            }
        }
        private int _rate;
        public int Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                if((value > -1) && (value < 11))
                {
                    _rate = value;
                }
                else
                {
                    throw new Exception("Rating no valido");
                }
            }
        }

        public Pelicula()
        {
            Titulo = "No asignado";
            Estreno = 2019;
            Director = "No asignado";
            Genero = "No asignado";
            Origen = "No asignado";
            Duracion = 0;
            Rate = 5;
            Sipnosis = "No asignado";
        }

        public Pelicula (string titulo, int estreno, string director, string genero, string origen, int duracion, int rate, string sipnosis)
        {
            Titulo = titulo;
            Estreno = estreno;
            Director = director;
            Genero = genero;
            Origen = origen;
            Duracion = duracion;
            Rate = rate;
            Sipnosis = sipnosis;
        }

    }
}
