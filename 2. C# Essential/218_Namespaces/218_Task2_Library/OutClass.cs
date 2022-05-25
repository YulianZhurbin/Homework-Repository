using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class OutClass
    {
        public void Print()
        {
			Console.WriteLine("OutClass.Print() is accessed");
        }
    }

    class InnerForOutClass
    {
        public void Method()
        {
            new OutClass().Print();

            Console.ReadKey();
        }
    }
}
