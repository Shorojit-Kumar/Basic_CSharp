using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class MethodsOverloding
    {

        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x,int y,int z)
        {
            return x + y + z;
        }

        public double Add(double x, double y, double z) {
            return x + y + z; 
        }

        public void ExecutionPoint()
        {
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Add(1,2,3));
            Console.WriteLine(Add(1.2,2.3,3.2));
       
        }
    }
}
