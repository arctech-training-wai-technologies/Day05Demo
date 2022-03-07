using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05Demo.Polymorphism
{
    internal class StaticPolymorphismDemo
    {
        public static void Test()
        {
            Box b = new Box(10, 20);

            // Polymorphism - Static Binding
            // Method overloading
            b.Show();
            b.Show(ConsoleColor.Red);
            b.Show();
        }
    }
}
