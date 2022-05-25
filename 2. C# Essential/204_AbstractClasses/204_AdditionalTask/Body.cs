using System;

namespace _204_AdditionalTask
{
    class Body : Document
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(base.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
