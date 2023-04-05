using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class SwitchCase
    {

        public dynamic sum(dynamic a,dynamic b)
        {
            return a + b;
        }
        public void main(string[] args)
        {
            Console.WriteLine(sum(1.2, 4));
            Console.WriteLine(sum(1, 2));

            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 10:
                    {
                        Console.WriteLine("The value is  10");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("This value is 20");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The value is greater than 20");
                        break;
                    }



            }
        }
    }
}
