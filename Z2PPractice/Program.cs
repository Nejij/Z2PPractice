using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal(name:"Bob");

            

            Console.WriteLine(myAnimal.Name);
        }
    }

    class Animal
    {
        public string Name { get; }

        public Animal()
        {
            Name = "No Name";
        }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
