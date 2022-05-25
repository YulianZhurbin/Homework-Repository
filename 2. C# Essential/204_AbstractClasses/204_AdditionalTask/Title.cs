using System;

namespace _204_AdditionalTask
{
    class Title : Document
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(base.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
