using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class StringBuilderMethods
    {

        public void ExecutionPoint()
        {
            StringBuilder sb = new StringBuilder("ABC", 50);

            
            sb.Append(new char[] { 'D', 'E', 'F' });

            
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');

            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            
            sb.Insert(0, "Alphabet: ");

            sb.Replace('k', 'K');


            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
        }

    }
}
