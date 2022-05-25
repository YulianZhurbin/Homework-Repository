using System;

namespace _203_Task3
{
    class Vehicle
    {
       //string latitude, longitude, price, velocity, releaseDate;

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Price { get; set; }
        public string Velocity { get; set; }
        public string ReleaseDate { get; set; }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"Latitude - {Latitude}");
            Console.WriteLine($"Longitude - {Longitude}");
            Console.WriteLine($"Price - {Price}");
            Console.WriteLine($"Velocity - {Velocity}");
            Console.WriteLine($"Production year - {ReleaseDate}");
        }
    }
}
