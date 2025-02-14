namespace Zaytsev_MINI_DZ
{
    // Абстрактный класс для травоядных.
    public abstract class Herbo : Animal
    {
        public int Kindness { get; set; }

        public Herbo(string name, int food, int number, int kindness)
            : base(name, food, number)
        {
            Kindness = kindness;
        }

        // Если больше 5-и, с животным можно контактировать. 
        public bool CanInteract() => Kindness > 5;

        public override string ToString()
        {
            return base.ToString() + $", доброта: {Kindness}";
        }
    }
}
