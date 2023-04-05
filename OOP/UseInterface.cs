using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_.OOP
{

    public interface IDrawable
    {
        public void Draw();
    }
    internal class UseInterface:IDrawable
    {
        public UseInterface() { }
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }

        public void ExecutionPoint()
        {
            UseInterface useInterface = new UseInterface();
            useInterface.Draw();
        }
    }
}
