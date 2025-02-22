﻿namespace Zaytsev_MINI_DZ
{
    // Класс для вещей.
    public class Thing : IInventory
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Thing(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString() => $"{Name} (№{Number})";
    }
}
