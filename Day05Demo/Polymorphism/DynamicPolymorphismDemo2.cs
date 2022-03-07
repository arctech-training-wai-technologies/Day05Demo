using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05Demo.Polymorphism
{
    internal class DynamicPolymorphismDemo2
    {
        public static void Test()
        {
            // Cannot instantiate animal because it is abstract
            //Animal a = new Animal();
            //a.Eat();
            //a.Sleep();

            Dog d = new Dog();
            d.Eat();
            d.Bark();
            d.Fight();
            d.Sleep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            cat.Fight();
            cat.Sleep();
        }
    }

    abstract class Animal
    {
        public abstract void Fight();

        public virtual void Sleep()
        {
            Console.WriteLine("Animal is going to sleep!");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating!");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bow Wow!");
        }

        public override void Fight()
        {
            Console.WriteLine("Dog is fighting");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is going to sleep!");
        }
    }

    class Cat : Animal
    {
        public override void Fight()
        {
            Console.WriteLine("Cat is fighting");
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }
}
