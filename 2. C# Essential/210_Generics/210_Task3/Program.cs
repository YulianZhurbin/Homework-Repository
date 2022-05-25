using System;

namespace _210_Task3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] key = new TKey[5];
        TValue[] arrayValue = new TValue[5];

        public TValue this[int index, TKey keyElement]
        {
            set
            {
                key[index] = keyElement;
                arrayValue[index] = value;
            }           
        } 

        public TValue this[TKey keyElement]
        {
            get
            {
                if(typeof(TValue) == typeof(TKey))
                {
                    for (int i = 0; i < arrayValue.Length; i++)
                    {
                        if(Convert.ToString(keyElement) == Convert.ToString(key[i]))
                        {
                            return arrayValue[i];
                        }
                    }
                }

                Console.WriteLine("There is no match");

                return default(TValue);
            }
        }

        public void AddPair(TKey el1, TValue el2)
        {
            TKey[] auxilaryKey = new TKey[key.Length + 1];
            Array.Copy(key, auxilaryKey, key.Length);
            auxilaryKey[auxilaryKey.Length - 1] = el1;
            key = auxilaryKey;

            TValue[] auxilaryValue = new TValue[arrayValue.Length + 1];
            Array.Copy(arrayValue, auxilaryValue, arrayValue.Length);
            auxilaryValue[auxilaryValue.Length - 1] = el2;
            arrayValue = auxilaryValue;
        }

        public int OverallAmount
        {
            get
            {
                return key.Length;
            }
        }

        public void Print()
        {
            Console.WriteLine("Dictionary:");

            for(int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i] + " - " + arrayValue[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();

            myDict[0, "яблоко"] = "apple";
            myDict[1, "апельсин"] = "orange";
            myDict[2, "груша"] = "pear";
            myDict[3, "банан"] = "banana";
            myDict[4, "персик"] = "peach";

            myDict.Print();

            Console.WriteLine("A new pair is added to the dictionary");

            myDict.AddPair("виноград","grapes");

            Console.Write("New ");
            myDict.Print();

            Console.WriteLine("Translation for \"банан\" is {0}", myDict["банан"]);

            Console.WriteLine("Overall amount of word pairs in dictionary = {0}", myDict.OverallAmount);

            Console.ReadKey();
        }
    }
}
