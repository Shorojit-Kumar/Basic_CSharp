using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    class Base
    {
        public void Display()
        {
            Console.WriteLine("I am from Base");
        }
    }

    class Derive1 : Base
    {
        public void Display()
        {
            Console.WriteLine("I am from Derive-1");
        }
    }
    class Derive2 : Derive1
    {
        public void Display()
        {
            Console.WriteLine("I am from Derive-2");
        }
    }
    internal class MethodOverriding
    {
        public void ExecutionPoint()
        {
            Derive2 derive2 = new Derive2();
            derive2.Display();
        }
    }
}
