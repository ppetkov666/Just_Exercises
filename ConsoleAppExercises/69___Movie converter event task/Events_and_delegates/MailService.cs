using System;
using System.Collections.Generic;
using System.Text;

namespace Events_and_delegates
{
    public class MailService
    {
        public void OnMovieConverter(object sender, MovieEventArgs e)
        {
            Console.WriteLine($"Mail service: sending an Email to {e.Movie.Title}");
        }
    }
}
