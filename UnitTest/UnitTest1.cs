using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MindBoxLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestCalculateAreaOFCircle()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            double expected = 78.5398163397;
            // Act
            double result = MBT.CalculateArea(5);
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCalculateAreaOFTriangle()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            double expected = 10.8253175473;
            // Act
            double result = MBT.CalculateArea(5,5,5);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestIsTriangleRightFalse()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            bool expected = false;
            // Act
            bool result = MBT.RightAngleByThreeEdges(5, 5, 5);
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestIsTriangleRightTrue()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            bool expected = true;
            // Act
            bool result = MBT.RightAngleByThreeEdges(3, 4, 5);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindBiggestEdgee()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            double expected = 5;
            // Act
            double result = MBT.FindBiggestEdgeOfTriangle(3, 4, 5);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindBiggestEdgeeTwoEqual()
        {
            // Arrange
            MindBoxLib.MindBoxTest MBT = new MindBoxLib.MindBoxTest();
            double expected = 5;
            // Act
            double result = MBT.FindBiggestEdgeOfTriangle(5, 4, 5);
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
