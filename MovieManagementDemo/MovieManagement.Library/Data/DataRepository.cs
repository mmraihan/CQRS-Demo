using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public class DataRepository
    {
        private static List<MovieModel> _movies = new()
        {
            new MovieModel { Id = 1, Name = "Inception", Cost = 560 },
            new MovieModel { Id = 2, Name = "Spiderman", Cost = 300 }

        };

        public MovieModel AddMovie(MovieModel movie)
        {

            _movies.Add(movie);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
