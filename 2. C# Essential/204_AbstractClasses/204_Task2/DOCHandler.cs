using System;

namespace _204_Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOCHandler Open()");
        }
        public override void Create()
        {
            Console.WriteLine("DOCHandler Create()");
        }
        public override void Change()
        {
            Console.WriteLine("DOCHandler Change()");
        }
        public override void Save()
        {
            Console.WriteLine("DOCHandler Save()");
        }
    }
}
