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
        public void main(string[] args)
        {

            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 10:
                    {
                        Console.WriteLine("The value is less than 10");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("This value is less than 20");
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
