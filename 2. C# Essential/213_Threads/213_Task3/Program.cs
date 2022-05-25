using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < rand.Next(10, 20); i++)
            {
                Console.WriteLine(rand.Next(0, 10));
            }

            Console.ReadKey();
        }
    }
}
