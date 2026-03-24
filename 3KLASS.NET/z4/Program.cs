using System;
using System.Collections.Generic;

public partial class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Duration { get; set; }
    public string Genre { get; set; }

    public Movie(string title, string director, int duration, string genre)
    {
        Title = title;
        Director = director;
        Duration = duration;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title}, реж. {Director}, {Duration} мин, жанр: {Genre}";
    }
}

public partial class Movie
{
    public static Movie GetLongestMovie(Movie[] movies)
    {
        if (movies == null || movies.Length == 0)
            return null;

        Movie longest = movies[0];
        for (int i = 1; i < movies.Length; i++)
        {
            if (movies[i].Duration > longest.Duration)
            {
                longest = movies[i];
            }
        }
        return longest;
    }

    public static List<Movie> GetMoviesByDirector(Movie[] movies, string director)
    {
        List<Movie> result = new List<Movie>();
        foreach (var movie in movies)
        {
            if (movie.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(movie);
            }
        }
        return result;
    }
}

class Cinema
{
    private Movie[] movies;

    public Cinema(Movie[] movies)
    {
        this.movies = movies;
    }

    public void DisplayAllMovies()
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }

    public Movie GetLongestMovie()
    {
        return Movie.GetLongestMovie(movies);
    }

    public List<Movie> GetMoviesByDirector(string director)
    {
        return Movie.GetMoviesByDirector(movies, director);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество фильмов: ");
        int n = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nФильм {i + 1}:");
            Console.Write("Введите название: ");
            string title = Console.ReadLine();
            Console.Write("Введите режиссера: ");
            string director = Console.ReadLine();
            Console.Write("Введите продолжительность (в минутах): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Введите жанр: ");
            string genre = Console.ReadLine();

            movies[i] = new Movie(title, director, duration, genre);
        }

        Cinema cinema = new Cinema(movies);

        Console.WriteLine("\nВсе фильмы:");
        cinema.DisplayAllMovies();

        Console.WriteLine("\nСамый длинный фильм:");
        Movie longest = cinema.GetLongestMovie();
        Console.WriteLine(longest);

        Console.Write("\nВведите имя режиссера для поиска его фильмов: ");
        string searchDirector = Console.ReadLine();

        List<Movie> directorMovies = cinema.GetMoviesByDirector(searchDirector);
        Console.WriteLine($"\nФильмы режиссера '{searchDirector}':");

        if (directorMovies.Count == 0)
        {
            Console.WriteLine("Фильмы не найдены");
        }
        else
        {
            foreach (var movie in directorMovies)
            {
                Console.WriteLine(movie);
            }
        }

        Console.ReadKey();
    }
}