using System;
using System.Collections.Generic;
using System.Text;

namespace Events_and_delegates
{
    public class MovieEventArgs : EventArgs
    {
        public Movie Movie { get; set; }
    }
}
