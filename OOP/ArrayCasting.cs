using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    
    internal class ArrayCasting
    {
        public ArrayCasting() { }

        public void ExecutionPoint(string[] args)
        {
            /// This is the normal process of declear diffrent types of array
            /*
            int[] ar=new int[15];
            bool[] bools=new bool[15];
            char[] chars=new char[15];
            long[] longs=new long[15];
            double[] doubles=new double[15];
            string[] strings=new string[15];
            */

            // We can also decleare dynamic types array which can contains any types of data;
            dynamic[] array = new dynamic[15];

            array[0] = 10;
            array[1] = "sagor";
            array[2] = false;

            for (int i = 0; i < 3;i++)
            {
                Console.WriteLine(array[i]);
                Console.WriteLine("YEs");
            }

        }
    }
}
