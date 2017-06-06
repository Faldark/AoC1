using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2016_Day_1_with_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGetter getter = new DataGetter();
            Coordinator coordinator = new Coordinator();
            Coordinates coordinates = new Coordinates();
            coordinates = coordinator.CalculateFinalCoordsFromDirectionsAdditionalStar(getter.ReturnArrayWithCoords());
            //Console.WriteLine("X:{0} \r\n Y:{1}", coordinates.X, coordinates.Y);
            Console.WriteLine("Answer is {0}", Math.Abs(coordinates.X) + Math.Abs(coordinates.Y));
            Console.ReadLine();
        }
    }
}
