using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class InsertIntoArray
    {
        public InsertIntoArray() { }
        public void main(string[] args)
        {
            dynamic[] ar=new dynamic[10];

            for(int i = 0; i < 10; i++)
            {
                ar[i]=new Random().Next(0,10);
            }

            for(int i=0; i < ar.Length; i++)
            {
                if (i == 5) continue;
                Console.WriteLine("Index "+i+": "+ar[i]);
            }
        }
    }
}
