using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Type an animal");
                string tipoAnimal = Console.ReadLine();
                tipoAnimal = tipoAnimal.ToLower();

                Animal animal = null;

                switch (tipoAnimal)
                {
                    case "cat":
                        animal = new Cat();
                        break;
                    case "dog":
                        animal = new Dog();
                        break;
                    case "pig":
                        animal = new Pig();
                        break;
                    case "elephant":
                        animal = new Elephant();
                        break;
                    case "lion":
                        animal = new Lion();
                        break;
                    case "cow":
                        animal = new Cow();
                        break;
                    default:
                        Console.WriteLine("Animal not found");
                        break;

                }

                if (animal != null)
                {
                    animal.AnimalSound();
                }

            }

        }
    }
}
