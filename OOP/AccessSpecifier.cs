using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class AccessSpecifier
    {
        private int _id;
        public string Name {  get; set; }

        protected int Age; 

        private void SetAge(int age)
        {
            this.Age = age;
        }

        public void ExecutionPoint()
        {
            AccessSpecifier ob = new AccessSpecifier();
            ob._id= 67;
            ob.Name = "Shorojit Kumar Sarkar";
            ob.SetAge(24);
            Console.WriteLine(ob.Name);
        }
    }

    class People
    {
        public void ExecutionPoint()
        {
            AccessSpecifier ob = new AccessSpecifier();
            ob.Name = "Shorojit Kumar Sarkar";
     
        }
    }


}
