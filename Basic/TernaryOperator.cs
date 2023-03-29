using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class TernaryOperator
    {
        public void main(string[] args)
        {
            int x = 5;
            int y = 10;
            int max = x > y ? x : y;
            Console.WriteLine("The max result is :" + max);


        }
    }
}
