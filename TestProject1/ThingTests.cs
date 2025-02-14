using Xunit;
using Zaytsev_MINI_DZ;

namespace Zaytsev_MINI_DZ.Tests
{
    public class ThingTests
    {
        [Fact]
        public void CreateThing_ShouldHaveCorrectProperties()
        {
            var table = new Table("Office Table", 301);
            var computer = new Computer("Dell PC", 302);

            Assert.Equal("Office Table", table.Name);
            Assert.Equal(301, table.Number);

            Assert.Equal("Dell PC", computer.Name);
            Assert.Equal(302, computer.Number);
        }
    }
}