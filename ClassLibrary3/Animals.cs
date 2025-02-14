namespace Zaytsev_MINI_DZ
{
    // Конкретный класс кролика – травоядное животное.
    public class Rabbit : Herbo
    {
        public Rabbit(string name, int food, int number, int kindness)
            : base(name, food, number, kindness)
        { }
    }

    // Конкретный класс обезьяны – травоядное животное.
    public class Monkey : Herbo
    {
        public Monkey(string name, int food, int number, int kindness)
            : base(name, food, number, kindness)
        { }
    }

    // Конкретный класс тигра – хищное животное.
    public class Tiger : Predator
    {
        public Tiger(string name, int food, int number)
            : base(name, food, number)
        { }
    }

    // Конкретный класс волка – хищное животное.
    public class Wolf : Predator
    {
        public Wolf(string name, int food, int number)
            : base(name, food, number)
        { }
    }


}
