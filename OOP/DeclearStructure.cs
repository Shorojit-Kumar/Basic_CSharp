using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
     struct Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public void  addInformations(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;  
            this.Address = address;
        }
        public void disPlay()
        {
            Console.WriteLine("Id :"+ Id);
            Console.WriteLine("Name :"+ Name);
            Console.WriteLine("Address :"+ Address);
        }
    }
    internal class DeclearStructure
    {

        public DeclearStructure() { }
        public void main(int id,string name,string address) {
           Customer customer = new Customer();
            customer.addInformations(id, name, address);
            customer.disPlay();
        }

    }
}
