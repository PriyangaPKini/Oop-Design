using System;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var upperRight = new Point(dimensions[0], dimensions[1]);
            Plateau plateau = new Plateau(upperRight);

            string[] initialPosition = Console.ReadLine().Split(" ");
            int x = int.Parse(initialPosition[0]);
            int y = int.Parse(initialPosition[1]);
            Direction orientation = (Direction)Enum.Parse(typeof(Direction), initialPosition[2]);
            Rover rover = new Rover(new Point(x, y), orientation);

            string commands = Console.ReadLine();
            System.Console.WriteLine(rover.Explore(commands));            
        }
    }
}
