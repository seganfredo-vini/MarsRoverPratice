using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1, 2, "N", plateau);
            Rover rover2 = new Rover(3, 3, "E", plateau);
            rover.ReadCommands("LMLMLMLMM");
            rover2.ReadCommands("MMRMMRMRRM");

            Console.WriteLine(rover.toString());
            Console.WriteLine(rover2.toString());
        }
    }
}
