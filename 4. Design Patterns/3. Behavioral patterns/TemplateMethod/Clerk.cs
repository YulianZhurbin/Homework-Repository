using System;

namespace TemplateMethod
{
    class Clerk : Human
    {
        protected override void PutOnFootwear()
        {
            Console.WriteLine("Shoes");
        }
        protected override void PutOnBottom()
        {
            Console.WriteLine("Trousers");
        }
        protected override void PutOnTop()
        {
            Console.WriteLine("Shirt");
        }
    }
}
