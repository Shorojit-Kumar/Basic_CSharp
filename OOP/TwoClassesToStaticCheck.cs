using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    class Person
    {
        private string name;
        public static void print(String somethings)
        {
            Console.WriteLine(somethings);
        }
    }
    internal class TwoClassesToStaticCheck
    {
        public void print(String somethings)
        {
            Console.WriteLine(somethings);
        }

        public void ExecutionPoint(string somethings)
        {
            Person.print(somethings);
            TwoClassesToStaticCheck ob=new TwoClassesToStaticCheck();
            ob.print("I am from second class without static ");
        }

    }
}
