using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class StringMethods
    {
        public void ExecutionPoint()
        {
            string myString = "Hello, World!";
            int length = myString.Length;
            int length1 = myString.Length;
            string substring1 = myString.Substring(7);     // "World!"
            string substring2 = myString.Substring(0, 5);  // "Hello"
            string replacedString = myString.Replace("Hello", "Hi");  // "Hi, World!"
            string upperCaseString = myString.ToUpper();    // "HELLO, WORLD!"
            string lowerCaseString = myString.ToLower();    // "hello, world!"
            string trimmedString = "    Hello, World!    ".Trim();   // "Hello, World!"
            string[] splitStrings = myString.Split(',');   // ["Hello", " World!"]

        }
    }
}
