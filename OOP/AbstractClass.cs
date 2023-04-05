using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{
    abstract class Base1
    {
 
        public abstract void Display();
        public abstract void Update(int id);
      
    }
    internal class AbstractClass: Base1
    {
        private int _id;
        public override void Display()
        {
            Console.WriteLine("Id :"+this._id);
        }
        public override void Update(int id)
        {
            this._id=id;
        }

        public void ExecutionPoint()
        {
            AbstractClass abstractClass = new AbstractClass();
            abstractClass.Update(100);
            abstractClass.Display();
            

        }
    }
}
