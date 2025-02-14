namespace Zaytsev_MINI_DZ
{
    // Интерфейс ветеринарной клиники.
    public interface IVeterinaryClinic
    {
        bool CheckHealth(Animal animal);
    }

    // Класс ветеринарной клиники для проверки состояния здоровья животных.
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
