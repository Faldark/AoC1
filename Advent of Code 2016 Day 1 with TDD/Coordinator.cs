using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;

namespace Advent_of_Code_2016_Day_1_with_TDD
{
    public class Coordinator
    {
        public Coordinates CalculateFinalCoordsFromDirections(string[] directions)
        {
            int intdirection = 1;
            Coordinates coords = new Coordinates();

            foreach (var direction in directions)
            {
                if (direction.Contains("R"))
                {
                    intdirection += 1;
                }
                else if (direction.Contains("L"))
                {
                    intdirection -= 1;
                }
                if (intdirection < 1)
                {
                    intdirection = 4;
                }
                else if (intdirection > 4)
                {
                    intdirection = 1;
                }
                string resultString = Regex.Match(direction, @"\d+").Value;
                int distance = Int32.Parse(resultString);
                if (intdirection == 1)
                {
                    coords.X += distance;
                }
                else if (intdirection == 2)
                {
                    coords.Y += distance;
                }
                else if(intdirection == 3)
                {
                    coords.X -= distance;
                }
                else if(intdirection == 4)
                {
                    coords.Y -= distance;
                }






                
                
            }
            return coords;
        }
        public Coordinates CalculateFinalCoordsFromDirectionsAdditionalStar(string[] directions)
        {
            int intdirection = 1;
            
            List<Coordinates> coordsList = new List<Coordinates>();

            foreach (var direction in directions)
            {
                Coordinates coords = new Coordinates();
                if (coordsList.Count >= 1)
                {
                    coords.X = coordsList.Last().X;
                    coords.Y = coordsList.Last().Y;
                }




                if (direction.Contains("R"))
                {
                    intdirection += 1;
                }
                else if (direction.Contains("L"))
                {
                    intdirection -= 1;
                }
                if (intdirection < 1)
                {
                    intdirection = 4;
                }
                else if (intdirection > 4)
                {
                    intdirection = 1;
                }
                string resultString = Regex.Match(direction, @"\d+").Value;
                int distance = Int32.Parse(resultString);
                if (intdirection == 1)
                {
                    coords.X += distance;
                }
                else if (intdirection == 2)
                {
                    coords.Y += distance;
                }
                else if (intdirection == 3)
                {
                    coords.X -= distance;
                }
                else if (intdirection == 4)
                {
                    coords.Y -= distance;
                }

                if (coordsList.Count >= 1)
                {
                    foreach (var coord in coordsList)
                    {
                        CompareLogic comparer = new CompareLogic();
                        if (comparer.Compare(coord, coords).AreEqual)
                        {
                            return coord;
                        }
                        
                    }
                }
                coordsList.Add(coords);







            }
            return coordsList.First();
        }
    }
}
