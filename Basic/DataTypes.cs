using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class DataTypes
    {

        public void main()
        {
            int myNum = 5;               // Integer 
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
            
            Console.WriteLine("Integer Value: " + myNum);
            Console.WriteLine("Double Value : " + myDoubleNum);
            Console.WriteLine("Charecter Type:  " + myLetter);
            Console.WriteLine("Bool Type:  " + myBool);
            Console.WriteLine("String Type:  " + myText);

            dynamic x = "Hello\n";
            dynamic y = 100;
        }
    }
}
