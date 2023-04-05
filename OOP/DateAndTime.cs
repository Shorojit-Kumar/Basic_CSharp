using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class DateAndTime
    {
        public void ExecutionPoint()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
                                              TimeSpan.Zero);
            Console.WriteLine(thisDate2);

            DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15);

            Console.WriteLine(date1.ToString("d, M",
                              CultureInfo.InvariantCulture));
            Console.WriteLine(date1.ToString("dddd dd MMMM",
                  CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
