using Xunit;
using Zaytsev_MINI_DZ;

namespace Zaytsev_MINI_DZ.Tests
{
    public class HerboTests
    {
        [Fact]
        public void CanInteract_ShouldReturnTrue_WhenKindnessAbove5()
        {
            // Arrange
            var rabbit = new Rabbit("Bunny", 2, 101, 6);

            // Act
            bool result = rabbit.CanInteract();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanInteract_ShouldReturnFalse_WhenKindness5OrBelow()
        {
            // Arrange
            var rabbit = new Rabbit("Fluffy", 2, 102, 5);

            // Act
            bool result = rabbit.CanInteract();

            // Assert
            Assert.False(result);
        }
    }
}
