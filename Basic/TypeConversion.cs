using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class TypeConversion
    {
        public void main(string[] args)
        {
            int intValue = 12345;

            double doubleValue = 123.444D;

            string strValue = "123445";

            //Explicit Conversion

            Console.WriteLine(Convert.ToInt32(strValue)); //Covert string to integer
            Console.WriteLine(Convert.ToInt64(strValue)); //Covert string to long long
            Console.WriteLine(Convert.ToDouble(strValue)); //Covert string to double
            Console.WriteLine(float.Parse(strValue)); //Covert string to double
            Console.WriteLine(Convert.ToBoolean(intValue)); //Convert integer to string
            Console.WriteLine(Convert.ToByte('A'));

            //Implicit converstion
            long x = intValue;
            int y = (int)x;



        }
    }
}
