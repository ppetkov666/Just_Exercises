using System;
using System.Collections.Generic;
using System.Text;

namespace Events_and_delegates
{
    public class MessageService
    {
        public void OnMovieConverter(object sender, MovieEventArgs e)
        {

            Console.WriteLine($"Message service: sending a text message to {e.Movie.Title}");
        }
    }
}
