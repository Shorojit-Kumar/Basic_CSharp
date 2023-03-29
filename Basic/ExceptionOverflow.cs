using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class ExceptionOverflow
    {
        public void main(string[] args)
        {
            int a = int.MaxValue;
            int b = 6;

            try
            {
                checked
                {
                    int c = a * b;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("An overflow exception occurred: " + ex.Message);
            }
        }
    }
}
