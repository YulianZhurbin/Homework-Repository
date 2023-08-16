using System;
using System.Collections.Generic;

#nullable disable

namespace Task2
{
    public partial class Buyer
    {
        public Buyer()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
