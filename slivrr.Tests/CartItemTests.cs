using System;
using Xunit;
using slivrr.Models;
namespace slivrr.Tests
{
    public class CartItemTests
    {
        [Fact]
        public void TotalPriceIsAccurate()
        {
            // Arrange
            var item = new Item {
                Price = 34.99M,
                QuantityInStock = 10
            };

            var cartItem = new CartItem {
                Id = 1,
                Item = item,
                Quantity = 3
            };

            var expected = 104.97M;

            // Act
            var actual = cartItem.getTotalPrice();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}