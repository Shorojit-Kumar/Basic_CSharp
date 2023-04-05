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
            long longInt = 123456789101112;
            float floatValue = 1000.0f;
            double doubleValue = 123.444D;

            string strValue = "123445";

            //Explicit Conversion

            Console.WriteLine(Convert.ToInt32(strValue)); //Covert string to integer
            Console.WriteLine(Convert.ToInt32(intValue)); 

            Console.WriteLine(Convert.ToInt64(strValue)); //Covert string to long
            Console.WriteLine(Convert.ToString(longInt));

            Console.WriteLine(Convert.ToDouble(strValue)); //Covert string to double
            Console.WriteLine(Convert.ToString(doubleValue));

            Console.WriteLine(float.Parse(strValue)); //Covert string to float
            Console.WriteLine(Convert.ToString(floatValue));

           
            Console.WriteLine(Convert.ToBoolean(intValue)); //Convert integer to boolean
            Console.WriteLine(Convert.ToInt32(true));

            

            char letter = 'A';
            int ascii = letter;

            int num = 97;
            char asciiChar = (char)num;


            //Implicit converstion
            long x = intValue;

            //Explicit type convertion 
            int y = (int)x;
        }
    }
}
