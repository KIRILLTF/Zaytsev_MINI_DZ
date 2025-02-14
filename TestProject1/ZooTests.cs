using Xunit;
using Zaytsev_MINI_DZ;
using System.Linq;

namespace Zaytsev_MINI_DZ.Tests
{
    public class ZooTests
    {
        [Fact]
        public void AddAnimal_ShouldIncreaseAnimalCount()
        {
            // Arrange
            IZoo zoo = new Zoo();
            int initialCount = zoo.GetAllAnimals().Count();

            var rabbit = new Rabbit("Bunny", 2, 101, 8);

            // Act
            zoo.AddAnimal(rabbit);

            // Assert
            Assert.Equal(initialCount + 1, zoo.GetAllAnimals().Count());
        }

        [Fact]
        public void GetTotalFoodConsumption_ShouldReturnCorrectSum()
        {
            // Arrange
            IZoo zoo = new Zoo();
            var rabbit = new Rabbit("Bunny", 2, 101, 8);
            var tiger = new Tiger("Sheru", 10, 202);
            zoo.AddAnimal(rabbit);
            zoo.AddAnimal(tiger);

            // Act
            int totalFood = zoo.GetAllAnimals().Sum(a => a.Food);

            // Assert
            Assert.Equal(12, totalFood);
        }

        [Fact]
        public void GetAllAnimals_ShouldReturnEmptyList_WhenNoAnimalsAdded()
        {
            // Arrange
            IZoo zoo = new Zoo();

            // Act
            var animals = zoo.GetAllAnimals();

            // Assert
            Assert.Empty(animals);
        }
    }
}

