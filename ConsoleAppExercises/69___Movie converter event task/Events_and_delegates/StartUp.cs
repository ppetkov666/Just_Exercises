using System;

namespace Events_and_delegates
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Title = "First Sample Movie";
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();
            MovieConverter converter = new MovieConverter();

            converter.MovieConvert += messageService.OnMovieConverter;
            converter.MovieConvert += mailService.OnMovieConverter;
            converter.Encode(movie);
        }
    }
}
