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
            Console.WriteLine($"Проводится медосмотр для животного: {animal.Name} (№{animal.Number}).");
            Console.Write("Введите состояние животного (здоров / не здоров): ");
            string input = Console.ReadLine().Trim().ToLower();
            return input == "здоров" || input == "здорова";
        }
    }
}
