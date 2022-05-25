using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211_Task2
{
    class Car
    {
        public string Name { get; set; }
        public string Year { get; set; }
    }

    class CarCollection<T> where T : Car, new()
    {
        T[] fleet;

        public CarCollection()
        {
            fleet = new T[0];
        }

        public void Add(string name, string year)
        {
            T[] tempArray = new T[fleet.Length + 1];

            for(int i = 0; i < fleet.Length; i++)
            {
                tempArray[i] = fleet[i];
            }

            T car = new T();
            car.Name = name;
            car.Year = year;

            tempArray[fleet.Length] = car;

            fleet = tempArray;
        }

        public T this[int index]
        {        
            get 
            {
                if (index <= fleet.Length)
                {
                    return fleet[index];
                }
                else
                {
                    Console.WriteLine("There is no garage with such a number");

                    return default(T);
                }
            }
        }

        public int Counter
        {
            get { return fleet.Length; }
        }

        public void Clear()
        {
            fleet = new T[0];
        }

        public void Print()
        {
            if(fleet.Length != 0)
            {
                for (int i = 0; i < fleet.Length; i++)
                {
                    Console.Write(fleet[i].Name + " " + fleet[i].Year + "  ");
                }
            }
            else
            {
                Console.WriteLine("No cars in the fleet");
            }

            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> list = new CarCollection<Car>();

            list.Add("LADA Kalina", "2008");
            list.Add("LADA Priora", "2012");
            list.Add("LADA Granta", "2012");
            list.Add("LADA Vesta", "2017");

            Car extractedCar = list[2];

            Console.WriteLine("Car in garage 3: {0} {1}. Overall amount of cars in the fleet = {2}", extractedCar.Name, extractedCar.Year, list.Counter);

            list.Print();

            Console.WriteLine(new string('-', 100));

            list.Clear();

            extractedCar = list[2];

            Console.WriteLine("Car in garage 3:{0}. Overall amount of cars in the fleet = {1}", extractedCar, list.Counter);

            list.Print();

            Console.ReadKey();
        }
    }
}
