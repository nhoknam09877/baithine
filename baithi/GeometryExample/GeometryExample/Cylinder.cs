using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{

    class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            Console.WriteLine("Base Area: " + (Math.PI * Radius * Radius).ToString("F2"));
            Console.WriteLine("Lateral Area: " + (2 * Math.PI * Radius * Height).ToString("F2"));
            Console.WriteLine("Total Area: " + (2 * Math.PI * Radius * (Height + Radius)).ToString("F2"));
            Console.WriteLine("Volume: " + (Math.PI * Radius * Radius * Height).ToString("F2"));
        }

        public void Result()
        {
            Console.WriteLine("\nCylinder characteristics");
            Console.WriteLine($"Radius: {Radius}, Height: {Height}");
            Process();
        }
    }


}
