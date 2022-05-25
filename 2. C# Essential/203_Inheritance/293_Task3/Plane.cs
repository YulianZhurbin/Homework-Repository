using System;

namespace _203_Task3
{
    class Plane : Vehicle
    {
        public string Height { get; set; }
        public string Seating { get; set; }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"Height - {Height}");
            Console.WriteLine($"Seating - {Seating}");
            base.ShowCharacteristics();
        }
    }
}
