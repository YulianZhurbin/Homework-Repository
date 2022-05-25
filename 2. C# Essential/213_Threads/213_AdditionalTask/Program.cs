using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _213_AdditionalTask
{
    class Program
    {
        static int counter = 0;
        static void Method()
        {
            Thread th2 = new Thread(new ThreadStart(Method));
            Console.WriteLine("Hash code = {0}", th2.GetHashCode().ToString());
            if (counter++ < 5)
            th2.Start();
        }

        static void Main(string[] args)
        {
            ThreadStart del1 = new ThreadStart(Method);
            Thread th1 = new Thread(del1);
            th1.Start();
            Thread.Sleep(500);
            Console.WriteLine("Main");
            Console.ReadKey();
        }
    }
}
