using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryWithArea.Tests
{
    [TestClass]
    public class LibraryWithAreaTests
    {
        [TestMethod]
        public void AreaForCircle_3_28_274333882returned()
        {
            double r = 3;
            double expected = 28.274333882;
            Circle circle = new Circle(r);

            double result = Math.Round(circle.Area(), 9);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void AreaForTriangle_3and9and10_13_266returned()
        {
            double a = 3;
            double b = 9;
            double c = 10;
            double expected = 13.266;
            Tringle tringle = new Tringle(a, b, c);

            double result = Math.Round(tringle.Area(),3);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void CheckTriangleForSquareness_3and4and5_TrueReturned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            Tringle tringle = new Tringle(a, b, c);

            bool result = tringle.CheckTriangleForSquareness(tringle);

            Assert.AreEqual(result, expected);
        }
    }
}
