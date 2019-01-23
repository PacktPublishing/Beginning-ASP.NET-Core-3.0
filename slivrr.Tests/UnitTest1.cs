using System;
using Xunit;

namespace slivrr.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int x;

            // Act
            x = 1;

            // Assert
            Assert.Equal(1, x);
        }
    }
}
