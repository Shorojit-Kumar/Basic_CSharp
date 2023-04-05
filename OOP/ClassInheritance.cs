using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    class Persons
    {
        private int _nidNumber;
        public string  FirstName;
        public string LastName;

        public Persons() { }
        public void SetNidNumber(int nidNumber)
        {
           this._nidNumber = nidNumber;
        }
    }

    class Customers: Persons
    {
        public Customers() { }
        public string Biodata;
       
    }
    class ShopsEmployee:Customers
    {
        public ShopsEmployee() { }
        public string Descriptions { set; get; }

    }

    internal class ClassInheritance
    {
       
        public void ExecutionPoint()
        {
            ShopsEmployee employee = new ShopsEmployee();
            
            employee.SetNidNumber(10001);
            employee.FirstName = "Shorojit";
            employee.LastName = "Sarkar";
            employee.Biodata = "So ......";
            employee.Descriptions = "Here your descriptions";
        }
    }
}
