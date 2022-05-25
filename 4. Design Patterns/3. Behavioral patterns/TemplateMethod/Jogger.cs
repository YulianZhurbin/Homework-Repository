using System;

namespace TemplateMethod
{
    class Jogger : Human
    {
        protected override void PutOnFootwear()
        {
            Console.WriteLine("Snickers");
        }  
        protected override void PutOnBottom()
        {
            Console.WriteLine("Shorts");
        }
        protected override void PutOnTop()
        {
            Console.WriteLine("T-shirt");
        }
    }
}
