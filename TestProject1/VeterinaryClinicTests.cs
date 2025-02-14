using Xunit;
using Moq;
using System.IO;
using System;
using Zaytsev_MINI_DZ;

namespace Zaytsev_MINI_DZ.Tests
{
    public class VeterinaryClinicTests
    {
        [Fact]
        public void CheckHealth_ShouldReturnTrue_WhenAnimalIsHealthy()
        {
            // Arrange
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("здоров\n"))
            {
                Console.SetIn(sr);

                // Act
                bool result = clinic.CheckHealth(animal);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void CheckHealth_ShouldReturnFalse_WhenAnimalIsUnhealthy()
        {
            // Arrange
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("не здоров\n"))
            {
                Console.SetIn(sr);

                // Act
                bool result = clinic.CheckHealth(animal);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void CheckHealth_ShouldThrowException_WhenInputIsInvalid()
        {
            // Arrange
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("непонятный ввод\n"))
            {
                Console.SetIn(sr);

                // Act & Assert
                Assert.Throws<Exception>(() => clinic.CheckHealth(animal));
            }
        }


        public bool CheckHealth(Animal animal)
        {
            Console.WriteLine($"Осмотр животного: {animal.Name}");
            string input = Console.ReadLine();

            if (input == "здоров") return true;
            if (input == "не здоров") return false;

            throw new Exception("Некорректный ввод");
        }

    }
}