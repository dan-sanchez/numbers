using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GreatCountingTests
{
    [TestClass]
    public class GreatCountingTest
    {
        [TestMethod]
        public void GetNumbers_ValidInputGiven_ShouldNotReturnNull()
        {
            // Arrange
            Dictionary<int, string> vals = new Dictionary<int, string>();
            vals.Add(7, "seven");
            vals.Add(11, "eleven");
            vals.Add(3, "fizz");
            vals.Add(5, "buzz");

            // Act
            var output = GreatCounting.GreatCounting.GetNumbers(vals);

            // Assert
            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void GetNumbers_ValidInputGiven_ShouldNotReturnEmpty()
        {
            // Arrange
            Dictionary<int, string> vals = new Dictionary<int, string>();
            vals.Add(7, "seven");
            vals.Add(11, "eleven");
            vals.Add(3, "fizz");
            vals.Add(5, "buzz");

            // Act
            var output = GreatCounting.GreatCounting.GetNumbers(vals);

            // Assert
            Assert.AreNotEqual(output, "");
        }
    }
}
