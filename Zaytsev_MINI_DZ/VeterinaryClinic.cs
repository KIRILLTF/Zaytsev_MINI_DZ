namespace Zaytsev_MINI_DZ
{
    // Интерфейс вет клиники.
    public interface IVeterinaryClinic
    {
        bool CheckHealth(Animal animal);
    }

    // Класс вет клиники для проверки здоровья животных.
    public class VeterinaryClinic : IVeterinaryClinic
    {
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
