using System;

namespace _204_AdditionalTask
{
    class Footer : Document
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(base.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
