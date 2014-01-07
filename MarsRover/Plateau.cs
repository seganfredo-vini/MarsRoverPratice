using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class Plateau
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public Plateau(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                this.x = x;
                this.y = y;
            }

            else
            {
                throw new OutOfBoundsException();
            }
                

        }

        public String toString()
        {
            return x + " " + y;
        }


    }
}
