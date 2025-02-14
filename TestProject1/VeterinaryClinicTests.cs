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
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("здоров\n"))
            {
                Console.SetIn(sr);

                bool result = clinic.CheckHealth(animal);

                Assert.True(result);
            }
        }

        [Fact]
        public void CheckHealth_ShouldReturnFalse_WhenAnimalIsUnhealthy()
        {
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("не здоров\n"))
            {
                Console.SetIn(sr);
                
                bool result = clinic.CheckHealth(animal);

                Assert.False(result);
            }
        }

        [Fact]
        public void CheckHealth_ShouldThrowException_WhenInputIsInvalid()
        {
            var clinic = new VeterinaryClinic();
            var animal = new Rabbit("Bunny", 1, 1, 8);

            using (var sr = new StringReader("непонятный ввод\n"))
            {
                Console.SetIn(sr);

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