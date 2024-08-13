using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    // Defina a class to represent a film
    public class Film
    {
        // Property to store the film's name
        public string FilmName { get; set; }

        // Property to store the film's IMDB rating
        public double ImdbPoint { get; set; }

        // Constructor to initialize a Film object with a name and rating
        public Film(string filmName, double imdbPoint)
        {
            FilmName = filmName;
            ImdbPoint = imdbPoint;
        }
    }
}
