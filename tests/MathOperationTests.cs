using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathLibrary;

namespace SimpleMathLibrary.Tests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var math = new MathOperations();
            int a = 5, b = 3;

            // Act
            int result = math.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            var math = new MathOperations();
            int a = 5, b = 3;

            // Act
            int result = math.Subtract(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
