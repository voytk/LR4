using System;
using System.Collections.Generic;
namespace ConsoleApp11
{
    class Person
    {
        
        public Person(Person previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }

       
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Details()
        {
            return Name + " is " + Age.ToString();
        }
    }

    class TestPerson
    {
        static void Main()
        {
           
            Person person1 = new Person("George", 40);

           
            Person person2 = new Person(person1);

            
            person1.Age = 39;
            person2.Age = 41;

           
            person2.Name = "Charles";

           
            Console.WriteLine(person1.Details());
            Console.WriteLine(person2.Details());

            
            Console.ReadKey();
        }
    }
}
