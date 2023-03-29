using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class Conditions
    {
        public void main()
        {

            int a = 10;
            int b = 10;
            if (a == b && a == 10)
            {
                Console.WriteLine("They are equal and the value is " + a);
            }
            else if (a != b || a > b)
            {
                Console.WriteLine("A is greater than B and a is not equal B");
            }
            else if (a > b)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("A is less than B");
            }


        }
    }
}
