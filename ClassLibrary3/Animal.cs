namespace Zaytsev_MINI_DZ
{
    // Абстрактный базовый класс для животных.
    public abstract class Animal : IAlive, IInventory
    {
        public string Name { get; set; }
        public int Food { get; set; }       // Количество потребляемой еды (кг/день)
        public int Number { get; set; }     // Инвентаризационный номер

        public Animal(string name, int food, int number)
        {
            Name = name;
            Food = food;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name} (№{Number}), потребляет {Food} кг/день";
        }
    }
}
