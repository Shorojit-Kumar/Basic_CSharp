using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    class Animals
    {
        public Animals() {
            Console.WriteLine("I am from Animals");
        }
        public void AnimalsSound(int n)
        {
            Console.WriteLine("Sounnd from animals");
        }
    }

    class Dogs : Animals
    {
        public Dogs():base()
        {
            Console.WriteLine("I am from Dogs");
        }
       public void DogsSound(int n)
        {
            Console.WriteLine("Sound from Dogs");
        }
    }
    internal class UpcastingAndDownCasting
    {
        public void ExecutionPoint()
        {
            Animals animals = new Dogs();
            Dogs dogs = new Dogs();

            Animals animals1 = dogs; //Upcasting
            Dogs dogs1 =(Dogs) animals; //Downcasting


        }
    }
}
