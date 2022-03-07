using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05Demo.Inheritance
{
    // Verson 1 Plane was created
    // Works well
    class Plane
    {
        public void Fly()
        {
            Console.WriteLine("Plane is Flying with bug fixed");
        }

        public void Refuel()
        {
            Console.WriteLine("Plane is Refueling");
        }
    }

    // Versio2 AdvancedPlane was created by
    // 1. Copy-Paste Plane class and rename
    // 2. Add additional data and methods
    // This is obviously similar to reusability in POP
    // See next example for inheritance in OOP
    class AdvancedPlane
    {
        public void FlyReverse()
        {
            Console.WriteLine("Plane is Flying on its back!!");
        }

        public void Fly()
        {
            Console.WriteLine("Plane is Flying with bug fixed");
        }

        public void Refuel()
        {
            Console.WriteLine("Plane is Refueling");
        }
    }
}
