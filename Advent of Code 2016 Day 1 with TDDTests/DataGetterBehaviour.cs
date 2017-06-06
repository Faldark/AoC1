using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_of_Code_2016_Day_1_with_TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advent_of_Code_2016_Day_1_with_TDDTests
{
    [TestClass()]
    public class DataGetterBehaviour
    {
        [TestMethod()]
        public void ReturnArrayWithCoordsTest()
        {
            //given
            DataGetter getter = new DataGetter();
            //when
            string[] coords = getter.ReturnArrayWithCoords();
            //then
            foreach (var coordinate in coords)
            {
                Assert.IsInstanceOfType(coordinate, typeof(string), "Coords consists of wrong type");
            }

            Assert.IsNotNull(coords, "Wrong filename or file doesnt exist");





        }

        [TestMethod()]
        public void ReturnArrayWithCoordsTestShouldReturnProperContent()
        {
            //given
            DataGetter getter = new DataGetter();
            string properArrayPattern = @"(.)(\d+)";
            Regex r = new Regex(properArrayPattern, RegexOptions.IgnoreCase);
            
            //when
            string[] coords = getter.ReturnArrayWithCoords();
            //then
            foreach (var coordinate in coords)
            {
                Assert.IsTrue(r.IsMatch(coordinate), "coordinates is wrong, please check file for suitability");
                
            }
            
        }



    }
}