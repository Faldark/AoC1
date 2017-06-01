using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Advent_of_Code_2016_Day_1_with_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent_of_Code_2016_Day_1_with_TDDTests
{
    [TestClass]
    public class CoordinatorBehaviour
    {
        [TestMethod]
        public void CalculateFinalCoordsFromDirectionsShouldReturnProperResult()
        {
            //given
            string[] inputDirections = new[] {"L1", "L2", "R3"};

            Coordinates properCoordinates = new Coordinates() {X = -2, Y = -4};
            //Dictionary<string, int> properCoords = new Dictionary<string, int>()
            //{
            //    {"Y", -1},
            //    {"X", -2},
            //    {"Y", -3}
            //};
            //string[] coords = new[] {"X", "-1"};

            //List<Coordinates> otherCoordinateses = new List<Coordinates>()
            //{
            //    { new Coordinates {Y = -1} },
            //    { new Coordinates {X = -2} },
            //    { new Coordinates {Y = -3} }
            //};
            
            

            //string[,] properCoords = new string[,] { { "X", "-1" }, { "X", "-1" }, { "X", "-1" } };

            Coordinator coordinator = new Coordinator();
            //when
            Coordinates calculatedCoordinates = coordinator.CalculateFinalCoordsFromDirections(inputDirections);
            //then
            Assert.AreEqual(properCoordinates, calculatedCoordinates, "something went wrong with calculating final coords for input directions");
        }
    }
}
