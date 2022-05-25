using System;

namespace _211_Task3
{
    class Program
    {
        class Dictionary<TKey, TValue>
        {
            TKey[] keys;
            TValue[] values;

            public Dictionary()
            {
                keys = new TKey[0];
                values = new TValue[0];
            }

            public void Add(TKey key, TValue val)
            {
                TKey[] tempKeys = new TKey[keys.Length + 1];

                for(int i = 0; i < keys.Length; i++)
                {
                    tempKeys[i] = keys[i];
                }

                tempKeys[keys.Length] = key;

                keys = tempKeys;


                TValue[] tempValues = new TValue[values.Length + 1];

                for (int i = 0; i < values.Length; i++)
                {
                    tempValues[i] = values[i];
                }

                tempValues[values.Length] = val;

                values = tempValues;
            }

            public TValue this[int index]
            {
                get
                {
                    return values[index];
                }         
            }

            public int Count
            {
                get
                {
                    return keys.Length;
                }
            }

            public void Print()
            {
                Console.ForegroundColor = ConsoleColor.Green;

                for(int i = 0; i < keys.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", keys[i], values[i]);
                }

                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "cat");
            myDictionary.Add(2, "dog");
            myDictionary.Add(3, "parrot");
            myDictionary.Add(4, "racoon");
            myDictionary.Add(5, "turtle");

            myDictionary.Print();

            Console.WriteLine("The fourth pet is {0}", myDictionary[3]);

            Console.WriteLine("Overall amount of pets = {0}", myDictionary.Count);

            Console.ReadKey();
        }
    }
}
