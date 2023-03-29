using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class ReferenceTypeVsPremitive
    {
        public int sum;
        public ReferenceTypeVsPremitive() { }
       
        public void main(string[] args)
        {
            ReferenceTypeVsPremitive ob = new ReferenceTypeVsPremitive();
            ob.sum = 10;
            ReferenceTypeVsPremitive ob1 = ob;
            ob1.sum = 20;
            Console.WriteLine(ob.sum); /// Object are reference type that reason change the value of sum in ob1


            int first = 10;
            int second = first;
            second = 20;
            Console.WriteLine(first); // Variables are premitive type that reason the value of first ic changed
        }
    }
}
