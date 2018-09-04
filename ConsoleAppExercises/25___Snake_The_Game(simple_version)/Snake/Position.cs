using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    struct Position
    {
        public int row;
        public int column;
        public Position(int row , int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
