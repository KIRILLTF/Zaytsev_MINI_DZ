namespace Zaytsev_MINI_DZ
{
    // Абстрактный класс для травоядных животных.
    public abstract class Herbo : Animal
    {
        public int Kindness { get; set; }   // Уровень доброты (0-10)

        public Herbo(string name, int food, int number, int kindness)
            : base(name, food, number)
        {
            Kindness = kindness;
        }

        // Метод, определяющий возможность интерактивного контакта.
        public bool CanInteract() => Kindness > 5;

        public override string ToString()
        {
            return base.ToString() + $", доброта: {Kindness}";
        }
    }
}
