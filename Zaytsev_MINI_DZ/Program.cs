using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Zaytsev_MINI_DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Startup.ConfigureServices();
            var zoo = serviceProvider.GetService<IZoo>();
            var vetClinic = serviceProvider.GetService<IVeterinaryClinic>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Меню ---");
                Console.WriteLine("1. Принять новое животное в зоопарк");
                Console.WriteLine("2. Показать отчет по количеству животных и их потреблению еды");
                Console.WriteLine("3. Показать список животных для контактного зоопарка");
                Console.WriteLine("4. Показать инвентаризационные вещи");
                Console.WriteLine("5. Добавить инвентаризационную вещь");
                Console.WriteLine("0. Выход");
                Coloring("Выберите опцию: ");
                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        AcceptNewAnimal(zoo, vetClinic);
                        break;
                    case "2":
                        ShowAnimalReport(zoo);
                        break;
                    case "3":
                        ShowInteractiveAnimals(zoo);
                        break;
                    case "4":
                        ShowInventoryItems(zoo);
                        break;
                    case "5":
                        AddInventoryItem(zoo);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверная опция, попробуйте снова.");
                        break;
                }
            }
        }

        /// <summary>
        /// Принимаем новое животное. 
        ///
        static void AcceptNewAnimal(IZoo zoo, IVeterinaryClinic vetClinic)
        {

            Console.Write("Введите тип животного (Rabbit, Monkey, Tiger, Wolf): ");
            string type = Console.ReadLine().Trim();

            Console.Write("Введите имя животного: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Введите количество потребляемой еды (кг/день): ");
            if (!int.TryParse(Console.ReadLine(), out int food))
            {
                Console.WriteLine("Некорректное значение для еды.");
                return;
            }

            Console.Write("Введите инвентаризационный номер: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Некорректное значение номера.");
                return;
            }

            Animal animal = null;

            // Если животное - травоядное, узнаем, насколько оно доброе.
            if (type.Equals("Rabbit", StringComparison.OrdinalIgnoreCase) ||
                type.Equals("Monkey", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Введите уровень доброты (0-10): ");
                if (!int.TryParse(Console.ReadLine(), out int kindness))
                {
                    Console.WriteLine("Некорректное значение доброты.");
                    return;
                }

                if (type.Equals("Rabbit", StringComparison.OrdinalIgnoreCase))
                    animal = new Rabbit(name, food, number, kindness);
                else if (type.Equals("Monkey", StringComparison.OrdinalIgnoreCase))
                    animal = new Monkey(name, food, number, kindness);
            }
            else if (type.Equals("Tiger", StringComparison.OrdinalIgnoreCase))
            {
                animal = new Tiger(name, food, number);
            }
            else if (type.Equals("Wolf", StringComparison.OrdinalIgnoreCase))
            {
                animal = new Wolf(name, food, number);
            }
            else
            {
                Console.WriteLine("Неизвестный тип животного.");
                return;
            }

            // Проверка состояния животного.
            bool isHealthy = vetClinic.CheckHealth(animal);
            if (isHealthy)
            {
                zoo.AddAnimal(animal);
                Console.WriteLine($"Животное {animal.Name} успешно принято в зоопарк.");
            }
            else
            {
                Console.WriteLine("Животное не прошло медосмотр и не может быть принято в зоопарк.");
            }
        }

        /// <summary>
        /// Вывод кол-ва потребляемой за сутки еды у всех животных.
        /// </summary>
        static void ShowAnimalReport(IZoo zoo)
        {
            var animals = zoo.GetAllAnimals();
            int totalFood = zoo.GetTotalFoodConsumption();
            Console.WriteLine($"Всего животных: {animals.Count()}");
            Console.WriteLine($"Общее количество потребляемой еды в день: {totalFood} кг");
        }

        /// <summary>
        /// Вывод животных, которые достаточно добрые для контактного зоопарка.
        /// </summary>
        static void ShowInteractiveAnimals(IZoo zoo)
        {
            var interactiveAnimals = zoo.GetInteractiveAnimals();
            Console.WriteLine("Животные, подходящие для контактного зоопарка:");
            foreach (var animal in interactiveAnimals)
            {
                Console.WriteLine(animal);
            }
        }

        /// <summary>
        /// Вывод списка вещей.
        /// </summary>
        static void ShowInventoryItems(IZoo zoo)
        {
            var items = zoo.GetInventoryItems();
            Console.WriteLine("Инвентаризационные вещи:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Добавление новой вещи.
        /// </summary>
        static void AddInventoryItem(IZoo zoo)
        {
            Console.Write("Введите тип вещи (Thing, Table, Computer): ");
            string type = Console.ReadLine().Trim();

            Console.Write("Введите наименование вещи: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Введите инвентаризационный номер: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Некорректное значение номера.");
                return;
            }

            IInventory item = null;
            if (type.Equals("Thing", StringComparison.OrdinalIgnoreCase))
                item = new Thing(name, number);
            else if (type.Equals("Table", StringComparison.OrdinalIgnoreCase))
                item = new Table(name, number);
            else if (type.Equals("Computer", StringComparison.OrdinalIgnoreCase))
                item = new Computer(name, number);
            else
            {
                Console.WriteLine("Неизвестный тип вещи.");
                return;
            }

            zoo.AddInventoryItem(item);
            Console.WriteLine($"Вещь {name} успешно добавлена.");
        }

        static public void Coloring(string text)
        {
            ConsoleColor color = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
