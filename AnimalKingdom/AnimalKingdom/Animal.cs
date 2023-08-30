using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
     class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public void SetMe(double weight, string name)
        {
            Name = name;
            Weight = weight;
        }
    }

    class Lion : Animal
    {
        public Lion(string name, double weight) : base(name, weight)
        {
        }
    }

    class Tiger : Animal
    {
        public Tiger(string name, double weight) : base(name, weight)
        {
        }
    }
}
