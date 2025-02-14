namespace Zaytsev_MINI_DZ
{
    // Класс стола – наследник Thing.
    public class Table : Thing
    {
        public Table(string name, int number)
            : base(name, number)
        { }
    }

    // Класс компьютера – наследник Thing.
    public class Computer : Thing
    {
        public Computer(string name, int number)
            : base(name, number)
        { }
    }
}
