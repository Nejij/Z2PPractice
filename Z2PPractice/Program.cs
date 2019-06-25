using System;

namespace Z2PPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Bob";
            myDog.NumberOfLegs = 4;
            myDog.Bark();

            Lab myLab = new Lab();
            myLab.Name = "Lassie";

            Console.WriteLine(myDog.Name);
        }
    }


    class Animal
    {
        public string Name { get; set; }
        public String Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm Breathing");
        }

        public void Eat()
        {

        }
    }
    class Dog : Animal
    {
        public int NumberOfLegs { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof");
        }

    }
    
    class Lab : Dog
    {

    }
}
