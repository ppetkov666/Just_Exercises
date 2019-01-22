using System;
using System.Threading;

namespace Events_and_delegates
{
    public class MovieConverter
    {
        public delegate void MovieConverterEventHandler(object sender, MovieEventArgs e);
        public event MovieConverterEventHandler MovieConvert;
        public void Encode(Movie movie)
        {
            Console.WriteLine($"Converting {movie.Title}...");
            Thread.Sleep(4000);
            OnMovieConvert(movie);
        }
        protected virtual void OnMovieConvert(Movie movie)
        {
            MovieConvert?.Invoke(this, new MovieEventArgs() { Movie = movie});
        }
    }
}
