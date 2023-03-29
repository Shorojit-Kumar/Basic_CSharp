using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class Lists
    {
        public void print(List<int> list)
        {
            Console.WriteLine("-------------------------------------------");
            foreach (int item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n--------------------------------------------");
        }
        
    public void main(string[] args)
        {
            List<int> lists=new List<int>();
            // add function adds a element in the end of list
            lists.Add(1);
            lists.Add(7);
            lists.Add(3);
            
            print(lists);



            //adding multiple element in a list;
            lists.AddRange(new List<int> { 4,5,6});
            
            print(lists);

            //search a number using binarysearch methods which takes O(log(n)) time
            int _index = lists.BinarySearch(4);
            Console.WriteLine(_index);

            //clear the list 
            //lists.Clear();

            //check a element is exist or not

            if (!lists.Contains((int)3))
            {
                Console.WriteLine("Not exist the element in the list");
            }

            //loop iterator
            foreach (dynamic item in lists)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");

            //insert element in specified index in a list

            lists.Insert(2,5);
            print(lists);
            
            //insert multiple element in a list
            lists.InsertRange(2, new List<int> { 4, 5});
            
            //Remove element based on value
            lists.Remove(4);

            //Remove element based on index
            lists.RemoveAt(3);
            //Remove list in a element
            //lists.RemoveRange(3, 2);
            
            print(lists);

            //Sorting a list
            lists.Sort((int a, int b)=> { return b.CompareTo(a); });
            print(lists);

            Console.WriteLine(lists.Capacity);
            Console.WriteLine(lists.Count);
            lists.TrimExcess();
            Console.WriteLine(lists.Capacity);

            ///TrueForAll methods in list
            ///
            bool result=lists.TrueForAll((int y) => { return y % 2 == 1; });
            Console.WriteLine(result);
        }

    }
}
