using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace TestProject1
{
    [TestClass]
    public class PlateauTest
    {

        [TestMethod()]
        public void TestIFCreateANewPlateauCorrectly()
        {
            Plateau plateau = new Plateau(5, 5);
            int expected = 5;
            Assert.AreEqual(expected, plateau.X);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenXValueIsNegative()
        {
            Plateau plateau = new Plateau(-1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenYValueIsNegative()
        {
            Plateau plateau = new Plateau(5, -1);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfThrowExceptionWhenXValueIsZero()
        {
            Plateau plateau = new Plateau(0, 5);
        }


        [TestMethod()]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestIfTrhowExceptionWhenYValueIsZero()
        {
            Plateau plateau = new Plateau(5, 0);
        }

    }
}
