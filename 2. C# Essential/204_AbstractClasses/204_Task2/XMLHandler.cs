using System;


namespace _204_Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XMLHandler Open()");
        }
        public override void Create()
        {
            Console.WriteLine("XMLHandler Create()");
        }
        public override void Change()
        {
            Console.WriteLine("XMLHandler Change()");
        }
        public override void Save()
        {
            Console.WriteLine("XMLHandler Save()");
        }
    }
}
