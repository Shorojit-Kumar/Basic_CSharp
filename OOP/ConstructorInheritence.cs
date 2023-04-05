using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    class Animal
    {
        public Animal(string name)
        {
            Console.WriteLine("Keeping an animal named " + name);
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Keeping a dog named " + name);
        }
    }


    internal class ConstructorInheritence
    {
        public void ExecutionPoint()
        {
            Dog myDog = new Dog("Rufus");
          

        }
    }
}
