using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.Basic
{
    internal class Loops
    {
        public void main(string[] args)
        {
            //for loops
            for (int i = 0; i < 100; i++)
            {
                if (i == 95)
                    continue;
                if (i == 99)
                    break;
            }
            //While loop
            int counter = 0;
            while (counter < 100)
            {
                counter++;
                if (counter == 95) { continue; }
                if (counter == 99) break;
            }
            //do while

            do
            {
                if (counter == 95) continue;
                if (counter == 99) break;

            } while (counter < 100);

            //forEach

            foreach (int i in Enumerable.Range(0, 100))
            {
                if (counter == 95) continue;
                if (counter == 99) break;
            }

        }
    }
}
