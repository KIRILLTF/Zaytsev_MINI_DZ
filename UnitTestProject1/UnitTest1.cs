using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Zaytsev_MINI_DZ;
using ClassLibrary3;


namespace Zaytsev_MINI_DZ.Tests
{
    [TestClass]
    public class ZooTests
    {
        [TestMethod]
        public void AddAnimal_ShouldIncreaseAnimalCount()
        {
            // Arrange

            Zaytsev_MINI_DZ.IZoo zoo = new Zoo();
            int initialCount = zoo.GetAllAnimals().Count();

            var rabbit = new Rabbit("Bunny", 2, 101, 8);

            // Act
            zoo.AddAnimal(rabbit);

            // Assert
            Assert.AreEqual(initialCount + 1, zoo.GetAllAnimals().Count());
        }

        [TestMethod]
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
            Assert.AreEqual(12, totalFood);
        }
    }
}