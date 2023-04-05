using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_C_.OOP
{

    class Sample
    {
        public string Name { get; set; }
    }
     class ReferenceTypeVsPremitive:ICloneable
    {
        public int sum;
        public Sample sample;
        public ReferenceTypeVsPremitive() { sample = null; }

        public object Clone()
        {
            ReferenceTypeVsPremitive newOb =(ReferenceTypeVsPremitive)this.MemberwiseClone();
            Sample sam= new Sample();
            sam.Name=this.sample.Name;
            newOb.sample = sam;
            return newOb;
        }

        public void ExecutionPoint(string[] args)
        {
            ReferenceTypeVsPremitive ob = new ReferenceTypeVsPremitive();
            ob.sum = 10;
            Sample sample = new Sample();
            sample.Name = "Sagor";
            ob.sample = sample;

            //Deepcopy
             ReferenceTypeVsPremitive deepCopy= (ReferenceTypeVsPremitive)ob.Clone();


            //Shallow copy
            ReferenceTypeVsPremitive shallowCopy = (ReferenceTypeVsPremitive)ob.MemberwiseClone();

            shallowCopy.sum = 20;
            shallowCopy.sample.Name = "Joy";

            

            // Console.WriteLine(ob1.sum);
            Console.WriteLine("{0}  {1}",ob.sum,ob.sample.Name);
            Console.WriteLine("{0}  {1}", shallowCopy.sum, shallowCopy.sample.Name);
            Console.WriteLine("{0}  {1}", deepCopy.sum, deepCopy.sample.Name);

            int first = 10;
            int second = first;
            second = 20;
            Console.WriteLine(first); // Variables are premitive type that reason the value of first ic changed
        }
    }
}
