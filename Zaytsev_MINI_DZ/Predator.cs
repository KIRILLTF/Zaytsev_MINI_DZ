namespace Zaytsev_MINI_DZ
{
    // Абстрактный класс для хищников.
    public abstract class Predator : Animal
    {
        public Predator(string name, int food, int number)
            : base(name, food, number)
        { }
    }
}
