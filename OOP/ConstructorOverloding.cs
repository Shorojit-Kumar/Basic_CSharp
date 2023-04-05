using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class ConstructorOverloding
    {
        public string Name;
        public int Age;
        public int Id;
        public ConstructorOverloding() { }
        public ConstructorOverloding(string name) { this.Name = name; }
        public ConstructorOverloding(string name,int age) { 
            this.Name = name;
            this.Age = age;
        }
        public ConstructorOverloding(string name,int age,int id) {
            this.Name=name;
            this.Age = age;
            this.Id = id;
         }

        public void ExecutionPoint()
        {
            ConstructorOverloding ob= new ConstructorOverloding();
            ConstructorOverloding ob1 = new ConstructorOverloding("Shorojit Sarkar");
            ConstructorOverloding ob2 = new ConstructorOverloding("Shorojit Sarkar", 24);
        }


    }
}
