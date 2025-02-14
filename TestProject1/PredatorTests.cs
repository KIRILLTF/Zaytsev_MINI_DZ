using Xunit;
using Zaytsev_MINI_DZ;

namespace Zaytsev_MINI_DZ.Tests
{
    public class PredatorTests
    {
        [Fact]
        public void Predator_ShouldHaveCorrectFoodConsumption()
        {
            // Arrange
            var tiger = new Tiger("Sheru", 10, 202);
            var wolf = new Wolf("Grey", 8, 303);

            // Act & Assert
            Assert.Equal(10, tiger.Food);
            Assert.Equal(8, wolf.Food);
        }
    }
}
