using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    internal class ClassDeclearation
    {
        string name;

        string Name { get; set; }
        public ClassDeclearation(string name) { 
            Name=name;
        }
        public ClassDeclearation() { }
        public void main(string[] args)
        {
            ClassDeclearation newClass = new ClassDeclearation("Shorojit Kumar Sarkar");
            Console.WriteLine(newClass.Name);
        }
    }
}
