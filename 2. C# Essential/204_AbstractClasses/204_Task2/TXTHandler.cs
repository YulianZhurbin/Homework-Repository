using System;

namespace _204_Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTHandler Open()");
        }
        public override void Create()
        {
            Console.WriteLine("TXTHandler Create()");
        }
        public override void Change()
        {
            Console.WriteLine("TXTHandler Change()");
        }
        public override void Save()
        {
            Console.WriteLine("TXTHandler Save()");
        }
    }
}
