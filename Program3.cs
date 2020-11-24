using System;

namespace ConsoleApp2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; protected set; }

        public abstract void GetInfo(); // объявление абстрактного метода
    }
    class Parrot : Animal
    {
        public Parrot(string name)
        {
            Name = name;
            Type = "Птица";
        }
        public override void GetInfo() // реализация абстрактного метода
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Имя: " + Name + "\n");
        }
    }
    class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
            Type = "Млекопитающее";
        }
        public override void GetInfo() // реализация абстрактного метода
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Имя: " + Name + "\n");
        }
    }
    class Tuna : Animal
    {
        public Tuna(string name)
        {
            Name = name;
            Type = "Рыба";
        }
        public override void GetInfo() // реализация абстрактного метода
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Имя: " + Name + "\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Animal> animals = new System.Collections.Generic.List<Animal>();
            animals.Add(new Parrot("Кеша"));
            animals.Add(new Cat("Пушок"));
            animals.Add(new Tuna("Тёма"));

            foreach (Animal animal in animals)
                animal.GetInfo();

            Console.ReadKey();
        }
    }
}
