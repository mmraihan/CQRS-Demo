using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public class DataRepository : IDataRepository
    {

        private static List<MovieModel> _movies = new()
        {
            new MovieModel { Id = 1, Name = "Inception", Cost = 200m },
            new MovieModel { Id = 2, Name = "The Blood Diamond", Cost = 300m }

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
