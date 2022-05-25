using _203_Task3;
using System;

namespace _203_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane boeing = new Plane();
            Car priora = new Car();
            Ship yacht = new Ship();

            boeing.Latitude = "60";
            boeing.Longitude = "30";
            boeing.Price = "100000 $";
            boeing.Velocity = "1000 mph";
            boeing.ReleaseDate = "2003";
            boeing.Height = "100 miles";
            boeing.Seating = "200";

            priora.Latitude = "50";
            priora.Longitude = "25";
            priora.Price = "200 000 rubles";
            priora.Velocity = "100 mph";
            priora.ReleaseDate = "2005";

            yacht.Latitude = "33";
            yacht.Longitude = "45";
            yacht.ReleaseDate = "2004";
            yacht.Port = "San Francisco";
            yacht.Seating = "12";

            Console.WriteLine("boeing");
            boeing.ShowCharacteristics();
            Console.WriteLine();

            Console.WriteLine("priora");
            priora.ShowCharacteristics();
            Console.WriteLine();

            Console.WriteLine("yacht");
            yacht.ShowCharacteristics();
            Console.WriteLine();


            //Delay
            Console.ReadKey();
        }
    }
}
