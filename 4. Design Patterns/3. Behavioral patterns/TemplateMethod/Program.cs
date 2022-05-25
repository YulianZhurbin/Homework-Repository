using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Human jogger = new Jogger();

            // template method call
            jogger.Dress();

            Human clerk = new Clerk();

            // template method call
            clerk.Dress();

            // Delay
            Console.ReadKey();

        }
    }
}
