using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            //Playlists
            Playlist pl1 = new Playlist("Terror", "Una playlists de peliculas de terror");
            Playlist pl2 = new Playlist("Animadas", "Una playlists de peliculas de animadas");

            playlists.Add(pl1);
            playlists.Add(pl2);

            //Peliculas terror
            Pelicula p1 = new Pelicula("El regreso del Ayuwoki", 2020, "Jonh Cena", "Terror", "USA", 100, 4, "El ayuwoki regresa");
            Pelicula p2 = new Pelicula("La muerte", 1990, "Andres R.", "Terror", "Mexico", 80, 3, "La muerte viene por ti");
            Pelicula p3 = new Pelicula("666", 2000, "Jonh Cena", "Terror", "USA", 90, 4, "El diablo y su numero");
            Pelicula p4 = new Pelicula("Estado Paranormal", 2013, "Jesus E.", "Terror", "Mexico", 70, 2, "Todo es paranormal");
            Pelicula p5 = new Pelicula("El espiritu de la niña", 1989, "Jonh Cena", "Terror", "USA", 50, 4, "Espiritu poseidor");
            Pelicula p6 = new Pelicula("Duendes reales", 2008, "Carlos E.", "Terror", "Mexico", 110, 4, "100% reales no feik");
            Pelicula p7 = new Pelicula("Horror abstracto", 2015, "Jonh Cena", "Terror", "USA", 120, 1, "Es abstracto");

            //Peliculas animadas
            Pelicula p8 = new Pelicula("Caillou", 2005, "Jonh Cena", "Infantil", "USA", 150, 4, "Es de caillou");
            Pelicula p9 = new Pelicula("Toy story", 2006, "Andres R.", "Animacion", "USA", 80, 4, "Juguetes vivos");
            Pelicula p10 = new Pelicula("Shrek", 2003, "Jonh Cena", "Animacion", "USA", 90, 4, "Ogro y cosas magicas");
            Pelicula p11 = new Pelicula("Cars", 2005, "Jesus E.", "Animacion", "USA", 70, 2, "Carros que hablan");
            Pelicula p12 = new Pelicula("Wall-e", 2011, "Jonh Cena", "Animacion", "USA", 100, 4, "Robot que viaja al espacio");
            Pelicula p13 = new Pelicula("Coco", 2018, "Carlos E.", "Animacion", "Mexico", 110, 4, "Niño con guitarra");
            Pelicula p14 = new Pelicula("Un pequeño problema", 2018, "9 productions", "Animacion", "Mexico", 2, 4, "Aliens");

            //Constructor vacio
            Pelicula pelicula1 = new Pelicula();

            pl1.peliculas.Add(p1);
            pl1.peliculas.Add(p2);
            pl1.peliculas.Add(p3);
            pl1.peliculas.Add(p4);
            pl1.peliculas.Add(p5);
            pl1.peliculas.Add(p6);
            pl1.peliculas.Add(p7);

            pl2.peliculas.Add(p8);
            pl2.peliculas.Add(p9);
            pl2.peliculas.Add(p10);
            pl2.peliculas.Add(p11);
            pl2.peliculas.Add(p12);
            pl2.peliculas.Add(p13);
            pl2.peliculas.Add(p14);

            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist: " + playlist.TituloP);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);
                Console.WriteLine("Lista de peliculas: ");
                foreach(Pelicula pelicula in playlist.peliculas)
                {
                    Console.WriteLine("Titulo: " + pelicula.Titulo);
                    Console.WriteLine("Año: " + pelicula.Estreno);
                    Console.WriteLine("Director: " + pelicula.Director);
                    Console.WriteLine("Genero: " + pelicula.Genero);
                    Console.WriteLine("Origen: " + pelicula.Origen);
                    Console.WriteLine("Duracion: " + pelicula.Duracion + " Minutos");
                    Console.WriteLine("Rating: " + pelicula.Rate + " Estrellas");
                    Console.WriteLine("Sipnosis: " + pelicula.Sipnosis);
                }
            }

            try
            {
                pelicula1.Estreno = 2020;
                Console.WriteLine("Año: " + pelicula1.Estreno);
            }
            catch (Exception e)
            {
                Console.WriteLine("Año fuera de rango");
            }

            try
            {
                pelicula1.Duracion = -1;
                Console.WriteLine("Duracion " + pelicula1.Duracion);
            }
            catch (Exception e)
            {
                Console.WriteLine("Duracion Invalida");
            }

            try
            {
                pelicula1.Rate = 6;
                Console.WriteLine("Rating " + pelicula1.Rate);
            }
            catch (Exception e)
            {
                Console.WriteLine("Rating no valido");
            }

            Console.ReadLine();

        }
    }
}
