namespace Zaytsev_MINI_DZ
{
    // Абстрактный класс для хищных животных.
    public abstract class Predator : Animal
    {
        public Predator(string name, int food, int number)
            : base(name, food, number)
        { }
    }
}
