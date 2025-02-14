using Xunit;
using Zaytsev_MINI_DZ;

namespace Zaytsev_MINI_DZ.Tests
{
    public class HerboTests
    {
        [Fact]
        public void CanInteract_ShouldReturnTrue_WhenKindnessAbove5()
        {
            var rabbit = new Rabbit("Bunny", 2, 101, 6);

            bool result = rabbit.CanInteract();

            Assert.True(result);
        }

        [Fact]
        public void CanInteract_ShouldReturnFalse_WhenKindness5OrBelow()
        {
            var rabbit = new Rabbit("Fluffy", 2, 102, 5);

            bool result = rabbit.CanInteract();

            Assert.False(result);
        }
    }
}
