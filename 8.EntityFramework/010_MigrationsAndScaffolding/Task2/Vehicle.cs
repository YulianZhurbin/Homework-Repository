using System;
using System.Collections.Generic;

#nullable disable

namespace Task2
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? BuyerId { get; set; }

        public virtual Buyer Buyer { get; set; }
    }
}
