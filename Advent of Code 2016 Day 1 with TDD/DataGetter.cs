using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2016_Day_1_with_TDD
{
    public class DataGetter
    {
        private string fileLocation = "D:\\input data\\AoCday1.txt";
        public string[] ReturnArrayWithCoords()
        {
            string[] data = File.ReadAllLines(fileLocation);

            string[] coords = null;

            foreach (var row in data)
            {
                coords = row.Split(',');
            }

            return coords;
        }
    }
}
