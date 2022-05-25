using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _211_Task4
{
    class MyList
    {
        object[] storage;

        public MyList()
        {
            storage = new object[0];
        }

        public void Add(object element)
        {
            object[] tempStorage = new object[storage.Length + 1];

            for(int i = 0; i < storage.Length; i++)
            {
                tempStorage[i] = storage[i];
            }

            tempStorage[storage.Length] = element;

            storage = tempStorage;
        }

        public object this[int index]
        {
            get
            {
                return storage[index];
            }
        }

        public int Count
        {
            get
            {
                return storage.Length;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(5);

            array.Add("zero");
            array.Add(1);
            array.Add("two");
            array.Add(3);

            Console.WriteLine("ArrayList instance:");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);

            Console.WriteLine(new string('-', 30));

            MyList list = new MyList();

            list.Add("zero");
            list.Add(1);
            list.Add("two");
            list.Add(3);

            Console.WriteLine("MyList instance:");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);

            Console.WriteLine(new string('-', 30));

            string zero = (string)list[0];
            int one = (int)list[1];
            string two = (string)list[2];
            int three = (int)list[3];

            Console.WriteLine("Experimentations:");
            Console.WriteLine(zero);
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);

            Console.ReadKey();
        }
    }
}
