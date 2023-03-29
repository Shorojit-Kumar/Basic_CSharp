using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    internal class EnumDeclearation
    {
        public EnumDeclearation() { }
        public void main(string[] args)
        {
            string day = "Monday";
            //Convert string to enum
            Days day0= (Days) Enum.Parse(typeof(Days), day);
            Days day1= Enum.Parse<Days>(day);
            Days day2= Enum.Parse<Days>(day,true);
            //Convert eum to string
            Enum myDay= Days.Sunday;
            Console.WriteLine(myDay.ToString());

            //Direct convert enum to string
            Console.WriteLine(Days.Tuesday.ToString());

            //convert int to enum
            Days intToEn = (Days)2;
            Console.WriteLine(intToEn);

            //convert enum to int
            int x=(int)Days.Sunday;
            Console.WriteLine(x);
        }

    }
}
