using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class Operators
    {
        public void main()
        {
            int a = 100;
            int b = 7;
            Console.WriteLine("Addition :" + (a + b));
            Console.WriteLine("Subtractions :" + (a - b));
            Console.WriteLine("Multiplications :" + a * b);
            Console.WriteLine("Division :" + a / b);
            Console.WriteLine("Modolus :" + a % b);
            Console.WriteLine("Bitwise or :" + (a | b));
            Console.WriteLine("Bitwise and :" + (a & b));
        }
    }
}
