using System;
using System.Threading;

namespace Event
{
    class Program
    {
        // false - установка несигнального состояния.
        static AutoResetEvent auto = new AutoResetEvent(false);

        static void Function()
        {
            Console.WriteLine("Запущен поток {0}", Thread.CurrentThread.Name);

            for (int i = 0; i < 80; i++)
            {
                Console.Write(".");
                Thread.Sleep(20);
            }

            Console.WriteLine("Завершен поток {0}", Thread.CurrentThread.Name);

            auto.Set(); // Посылает сигнал первичному потоку - [продолжиться].
        }

        static void Main()
        {
            Thread thread = new Thread(Function) { Name = "1" }; // 1-й ПОТОК.
            thread.Start();

            Console.WriteLine("Приостановка выполнения первичного потока.");
            auto.WaitOne();

            Console.WriteLine("Первичный поток возобновил работу.");

            thread = new Thread(Function) { Name = "2" }; // 2-й ПОТОК.
            thread.Start();

            Console.WriteLine("Приостановка выполнения первичного потока.");
            auto.WaitOne();

            Console.WriteLine("Первичный поток возобновил и завершил работу.");

            // Delay
            Console.ReadKey();
        }
    }
}
