using System;

namespace _203_Task3
{
    class Ship : Vehicle
    {
       public string Seating { get; set; }

       public string Port { get; set; }

       public void ShowCharacteristics()
       {
            Console.WriteLine($"Seating - {Seating}");
            Console.WriteLine($"Port - {Port}");
            base.ShowCharacteristics();
       }
    }
}
