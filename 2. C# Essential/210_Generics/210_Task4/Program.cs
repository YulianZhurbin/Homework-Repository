using System;

namespace _210_Task4
{
    static class ExtendingClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Arr];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];
            }

            Console.WriteLine("\nExtending method GetArray is applied.\n");
            return arr;
        }
    }

    class MyList<T>
    {
        T[] array;

        public MyList(int arrayLength)
        {
            array = new T[arrayLength];
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }

        public void AddOne(T element)
        {
            T[] auxilaryArray = new T[array.Length + 1];

            Array.Copy(array, auxilaryArray, array.Length);

            auxilaryArray[auxilaryArray.Length - 1] = element;

            array = auxilaryArray;
        }

        public int Arr
        {
            get
            {
                return array.Length;
            }
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> array = new MyList<int>(3);

            array[0] = 9;
            array[1] = 8;
            array[2] = 7;

            Console.Write("Initial array = ");
            array.Print();

            array.AddOne(6);
            Console.WriteLine($"{array[3]} is added as the last element in the array");

            Console.Write("The renewed array = ");
            array.Print();

            Console.WriteLine("The second element of the array = {0}", array[1]);

            Console.WriteLine("The array has {0} elements", array.Arr);

            Console.WriteLine(new string('-', 50));

            Console.ForegroundColor = ConsoleColor.Green;

            MyList<string> stringArray = new MyList<string>(3);

            stringArray[0] = "nine";
            stringArray[1] = "eight";
            stringArray[2] = "seven";

            Console.Write("Initial array = ");
            stringArray.Print();

            stringArray.AddOne("six");
            Console.WriteLine($"{stringArray[3]} is added as the last element in the array");

            Console.Write("The renewed array = ");
            stringArray.Print();

            Console.WriteLine("The second element of the array = {0}", stringArray[1]);

            Console.WriteLine("The array has {0} elements", stringArray.Arr);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write(new string('-', 50));

            Console.ForegroundColor = ConsoleColor.Yellow;

            int[] extMethIntArray = array.GetArray();

            for (int i = 0; i < extMethIntArray.Length; i++)
            {
                Console.Write(extMethIntArray[i] + "  ");
            }

            string[] extMethStringArray = stringArray.GetArray();

            for (int i = 0; i < extMethStringArray.Length; i++)
            {
                Console.Write(extMethStringArray[i] + "  ");
            }

            Console.ReadKey();
        }
    }
}
