using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class ArrayImplementation
    {
        
        public void ExecutionPoint()
        {
            int[] ar = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Object[] ar2 = new Object[5] { 1, 2, 3, 4, 5 };
            Array array =Array.CreateInstance(typeof(Array),3,3);
            int[][] jaggedArray = new int[6][];

            Console.WriteLine(ar.GetType());
            Console.WriteLine(ar2.GetType());
            Console.WriteLine(array.GetType());

            Console.WriteLine(ar2.IsFixedSize);
            Console.WriteLine(ar2.LongLength);
            Console.WriteLine(ar2.Max()); 
            Console.WriteLine(ar2.Min());
            Console.WriteLine(ar2.Rank);


           lock (ar2.SyncRoot)
            {
                foreach(int i in ar2) Console.Write(i);
                Console.WriteLine();
            }
            //Only read only statement here

            Console.WriteLine(Array.BinarySearch(ar2, 1));
            Array.Clear(ar2);
            int[]  copArray= (int[])ar.Clone() ;

            int[] rangeCpy =new int[3];

            Array.ConstrainedCopy(ar, 0, rangeCpy, 0, 3);
            Array.Copy(ar,rangeCpy, 3);
            ar.CopyTo(copArray, 0);

            Array.Reverse(rangeCpy);
            Array.Reverse(rangeCpy, 0, 2);
            Array.Equals(ar, rangeCpy);
            Array.Exists(ar, x => (x%2==0) );

            int val = Array.Find(ar, x => (x % 2 == 0));
            int[] arr= Array.FindAll(ar, x => (x % 2 == 0));

            Array.Sort(arr, (int x, int y) =>x.CompareTo(y));

        }
    }
}
