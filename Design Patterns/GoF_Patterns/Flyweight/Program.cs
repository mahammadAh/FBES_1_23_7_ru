
using Flyweight;

public class Program
{
    public static void Main(string[] args)
    {
        MovieService movieService = new MovieService();

        List<string> movieList = new List<string>
        {
            "law",
            "Interstellar",
            "The Shawshank Redemption",
            "Oppenheimer"
        };

        while (true)
        {
            int i = 1;
            movieList.ForEach(movie => Console.WriteLine($"{(i++).ToString()}) {movie}"));
            int selectedMovie = Convert.ToInt32(Console.ReadLine());

            Movie foundMovie = movieService.SearchMovie(movieList[selectedMovie - 1]);
            Console.WriteLine(foundMovie+"\n");
        }

    }

}

