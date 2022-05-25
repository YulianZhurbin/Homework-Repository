using System;

namespace _210_AdditionalTask
{
    class MyClass<T> where T : new()
    {
        public static T ProduceOne()
        {
            T instance = new T();

            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = MyClass<int>.ProduceOne();

            Console.WriteLine(number.GetType().Name);

            Program line = MyClass<Program>.ProduceOne();

            Console.WriteLine(line.GetType().Name);

            Console.ReadKey();
        }
    }
}
