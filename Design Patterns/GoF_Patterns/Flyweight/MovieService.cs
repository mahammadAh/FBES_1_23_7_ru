using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Flyweight
{

    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"Title : {Title} \nYear : {Year} \nGenre : {Genre}";
        }


    }

    public class MovieCache
    {
        public Dictionary<string, Movie> Movies { get; set; }

        public MovieCache()
        {
            Movies = new Dictionary<string, Movie>();
        }

        public Movie CheckMovie(string title)
        {
            Console.WriteLine("Search movie in Cache...");
            if (Movies.ContainsKey(title))
            {
                return Movies[title];
            }
            else return null;
        }

        public void AddMovie(Movie movie)
        {
            Movies[movie.Title] = movie;
        }
    }

    public class MovieService
    {
        public MovieCache cachedMovies { get; set; }


        public MovieService()
        {
            cachedMovies = new MovieCache();
        }


        public Movie SearchMovie(string title)
        {
            Movie movie;

            movie = cachedMovies.CheckMovie(title);

            if (movie == null)
            {
                Console.WriteLine("Search movie info with API...");
                string omdbApi = @"http://www.omdbapi.com/";
                string i = "tt3896198";
                string apiKey = "afce4cfd";
                WebClient webClient = new WebClient();
                string resultJson = webClient.DownloadString($"{omdbApi}?i={i}&apikey={apiKey}&t={title}");
                movie = JsonSerializer.Deserialize<Movie>(resultJson);
                cachedMovies.AddMovie(movie);
            }

            return movie;
          

        }
    }
}
