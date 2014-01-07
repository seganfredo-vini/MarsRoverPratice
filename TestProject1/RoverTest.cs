using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using NUnit;

namespace TestProject1
{
    [TestClass]
    public class RoverTest
    {

        [TestMethod()]
        public void RoverConstructorTest()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1, 2, "N", plateau);
            
            int expected = 1;
            Assert.AreEqual(expected, rover.PlateauX);
            expected = 2;
            Assert.AreEqual(expected, rover.PlateauY);
            String expected2 = "N";
            Assert.AreEqual(expected2, rover.Direction);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenXRoverPlateauPositionIsNegative()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(-2, 2, "N", plateau);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenYRoverPlateauPositionIsNegative()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(4, -2, "N", plateau);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenRoverXPlateauPositionGoesOutOfPlateauLimits()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(8, 4, "N", plateau);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenRoverYPlateauPositionGoesOutOfPlateauLimits()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(4, 8, "N", plateau);
        }
        

        [TestMethod()]
        [ExpectedException(typeof(InvalidStringValueException))]
        public void TestIfThrowExceptionWhenInstructionIsInvalid()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(5, 5, "Z", plateau);
        }


        [TestMethod()]
        public void RoverReadCommandsTest()
        {
            Plateau plateau = new Plateau(5,5);
            Rover rover = new Rover(1, 2, "N", plateau);

            String expected = "N";
            Assert.AreEqual(expected, rover.ReadCommands("LLLL"));
            
        }


        [TestMethod()]
        public void RoverReadCommandsTestWithMove()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1, 2, "N", plateau);


            int expectedX = 1;
            int expectedY = 3;
            String expected = "N";
            rover.ReadCommands("LMLMLMLMM");
            Assert.AreEqual(expected, rover.Direction);
            Assert.AreEqual(expectedX, rover.PlateauX);
            Assert.AreEqual(expectedY, rover.PlateauY);

        }


        [TestMethod()]
        public void RoverReadCommandsTestWithAnotherRover()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(3,3,"E",plateau);

            rover.ReadCommands("MMRMMRMRRM");

            int expectedX = 5;
            int expectedY = 5;
            String expected = "E";
            Assert.AreEqual(expected, rover.Direction);
            Assert.AreEqual(expectedX, rover.PlateauX);
            Assert.AreEqual(expectedY, rover.PlateauY);  
        }

        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestMoveMethodException()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1,2,"N",plateau);

            rover.ReadCommands("MMMMM");
        }


        [TestMethod()]
        public void TestTurnLeft90DegreesMethod()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2, 2, "S", plateau);

            rover.turn90DegreesToLeft();

            String expectedState = "W";

            NUnit.Framework.Assert.That(rover.Direction, NUnit.Framework.Is.EqualTo(expectedState));
                        
        }


        [TestMethod()]
        public void TestTurnRight90DegreesMethod()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2, 2, "N", plateau);

            rover.turn90DegreesToRight();

            String expectedState = "W";

            NUnit.Framework.Assert.That(rover.Direction, NUnit.Framework.Is.EqualTo(expectedState));
        }


        [TestMethod()]
        public void TestMoveMethod()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2,2,"N",plateau);

            rover.moveRover();

            int expectedState = 3;
            NUnit.Framework.Assert.That(rover.PlateauY, NUnit.Framework.Is.EqualTo(expectedState));


        }

        [TestMethod()]
        public void TestToString()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(1, 2, "N", plateau);

            Assert.IsNotNull(rover.toString());


        }
    }
}
