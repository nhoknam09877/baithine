using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{

    class Program
    {
        static void Main(string[] args)
        {
             Lion lion = new Lion("Lion ", 100);
            Tiger tiger = new Tiger(" Tiger", 200);

            Console.WriteLine("Lion Details:");
            lion.Show();

            Console.WriteLine("\nTiger Details:");
            tiger.Show();

          



        }
    }
}

