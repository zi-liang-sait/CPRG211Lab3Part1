//CPRG 211 F Lab 3 - Interfaces and Abstract classes
//Michael (Zi) Liang 000921925
//Feb 4, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog's name:");
            string dogName = Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.Name = dogName;
            dog1.Colour = "Brown";
            dog1.Age = 2;
            Console.WriteLine($"{dog1.Name} is a {dog1.Colour}, {dog1.Age} year old dog.");
            dog1.Eat();

            Console.WriteLine("Please enter a cat's name:");
            string catName = Console.ReadLine();
            Cat cat1 = new Cat();
            cat1.Name = catName;
            cat1.Colour = "White";
            cat1.Age = 3;
            Console.WriteLine($"{cat1.Name} is a {cat1.Colour}, {cat1.Age} year old cat.");
            cat1.Eat();
        }
    }
}
